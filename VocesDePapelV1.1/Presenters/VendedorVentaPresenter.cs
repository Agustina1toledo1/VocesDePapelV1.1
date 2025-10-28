using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Repositories;
using VocesDePapelV1._1.Views;

namespace VocesDePapelV1._1.Presenters
{
    public class VendedorVentaPresenter
    {
        private readonly IVendedorVenta view; //campo privado para la vista usando la interfa
        private readonly IProductoSearchView productoSearchView; // 
        private readonly string connectionString; // Almacena la cadena de conexión
        private readonly IClienteRepository clienteRepository; // Repositorio de Cliente para la busqueda
        private readonly IUsuarioRepository usuarioRepository; // Repositorio para usuarios/vendedores
        private readonly IVentaCabeceraRepository ventaCabeceraRepository; // Repositorio para la venta
        private readonly IVentaDetalleRepository detalleRepo;
        private readonly IProductoRepository productoRepo;
        private readonly List<VentaDetalleModel> detallesVenta;
        private UsuarioModel usuarioActual;
        private List<ProductoModel> productosEncontrados;
        // Constructor
        public VendedorVentaPresenter(IVendedorVenta view, string connectionString)
        {
            this.view = view;
            this.connectionString = connectionString;
            this.clienteRepository = new ClienteRepository(connectionString);
            this.usuarioRepository = new UsuarioRepository(connectionString);
            this.ventaCabeceraRepository = new VentaCabeceraRepository(connectionString);
            this.detalleRepo = new VentaDetalleRepository(connectionString);
            this.productoRepo = new ProductoRepository(connectionString);
            this.detallesVenta = new List<VentaDetalleModel>();
            this.productosEncontrados = new List<ProductoModel>();


            // Obtener usuario actual (deberías pasar esto como parámetro o obtenerlo del login)
            this.usuarioActual = new UsuarioModel { Id_usuario = 1 }; // Temporal

            SuscribirEventos();
            InicializarVista();
            this.view.Show();
        }
        private void SuscribirEventos()
        {
            this.view.AddNewClienteEvent += AbrirVistaCliente;
            this.view.SearchClienteByCuitEvent += BuscarClientePorCuit;
            this.view.ClearClienteEvent += LimpiarCliente;
            this.view.SearchVendedorByCuitEvent += BuscarVendedorPorCuit;
            this.view.AgregarProductoEvent += OnAgregarProducto;
            this.view.BuscarProductoEvent += OnBuscarProducto;
            this.view.EliminarProductoEvent += OnEliminarProducto;
            this.view.FinalizarVentaEvent += OnFinalizarVenta;
            this.view.CancelarVentaEvent += OnCancelarVenta;
            this.view.CantidadCambiadaEvent += OnCantidadOPrecioCambiado;
            this.view.PrecioCambiadoEvent += OnCantidadOPrecioCambiado;
        }
        private void InicializarVista()
        {
            view.FechaVenta = DateTime.Now;
            CargarProximoNumeroFactura();
            view.NumeroFactura = ventaCabeceraRepository.ObtenerProximoNumeroFactura().ToString();
            view.ProductoCantidad = 1; // Cantidad por defecto
        }

        private void OnAgregarProducto(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if (view.ProductoSeleccionadoId <= 0)
                {
                    view.MostrarMensaje("Debe seleccionar un producto", false);
                    return;
                }

                if (view.ProductoCantidad <= 0)
                {
                    view.MostrarMensaje("La cantidad debe ser mayor a 0", false);
                    return;
                }

                if (view.ProductoPrecio <= 0)
                {
                    view.MostrarMensaje("El precio debe ser mayor a 0", false);
                    return;
                }

                // Buscar el producto seleccionado
                var producto = productosEncontrados.FirstOrDefault(p => p.Id_libro == view.ProductoSeleccionadoId);
                if (producto == null)
                {
                    view.MostrarMensaje("Producto no encontrado", false);
                    return;
                }

                // Verificar stock disponible
                if (producto.Stock < view.ProductoCantidad)
                {
                    view.MostrarMensaje($"Stock insuficiente. Stock disponible: {producto.Stock}", false);
                    return;
                }

                // Crear detalle de venta
                var detalle = new VentaDetalleModel
                {
                    Id_libro = view.ProductoSeleccionadoId,
                    Cantidad = view.ProductoCantidad,
                    Precio_unitario = view.ProductoPrecio,
                   // Subtotal = view.ProductoCantidad * view.ProductoPrecio,
                    Titulo_libro = producto.Titulo
                };

                // Agregar a la lista de detalles
                view.AgregarDetalle(detalle);

                // Actualizar total
                ActualizarTotalVenta();

                // Limpiar campos de producto
                view.ProductoCantidad = 1;
                view.ProductoPrecio = 0;

                view.MostrarMensaje("Producto agregado correctamente", true);
            }
            catch (Exception ex)
            {
                view.MostrarMensaje($"Error al agregar producto: {ex.Message}", false);
            }
        }

        private void OnBuscarProducto(object sender, EventArgs e)
        {
            MostrarBusquedaProductos();
        }

        private void OnEliminarProducto(object sender, EventArgs e)
        {
            try
            {
                // En una implementación real, esto recibiría el índice del producto a eliminar
                // Por simplicidad, asumimos que se elimina el último o se tiene una selección
                if (view.Detalles.Count > 0)
                {
                    view.EliminarDetalle(view.Detalles.Count - 1);
                    ActualizarTotalVenta();
                    view.MostrarMensaje("Producto eliminado del carrito", true);
                }
            }
            catch (Exception ex)
            {
                view.MostrarMensaje($"Error al eliminar producto: {ex.Message}", false);
            }
        }

        private void OnFinalizarVenta(object sender, EventArgs e)
        {
            try
            {
                // Validaciones finales
                if (view.IdCliente <= 0)
                {
                    view.MostrarMensaje("Debe seleccionar un cliente", false);
                    return;
                }

                if (view.Detalles.Count == 0)
                {
                    view.MostrarMensaje("Debe agregar al menos un producto", false);
                    return;
                }

                // Verificar stock nuevamente antes de finalizar
                foreach (var detalle in view.Detalles)
                {
                    var producto = productoRepo.GetAll().FirstOrDefault(p => p.Id_libro == detalle.Id_libro);
                    if (producto?.Stock < detalle.Cantidad)
                    {
                        view.MostrarMensaje($"Stock insuficiente para: {detalle.Titulo_libro}", false);
                        return;
                    }
                }

                // Usar transacción para garantizar consistencia
                using (var transaction = new TransactionScope())
                {
                    // Crear cabecera de venta
                    var cabecera = new VentaCabeceraModel
                    {
                        Fecha_hora = DateTime.Now,
                        Total_venta = view.TotalVenta,
                        Id_cliente = view.IdCliente,
                        Id_usuario = usuarioActual.Id_usuario,
                        Id_estado = 1 // Activo
                    };

                    // Guardar cabecera y obtener ID
                    ventaCabeceraRepository.Add(cabecera);
                    var idCabecera = cabecera.Id_venta_cabecera;

                    // Guardar detalles
                    foreach (var detalle in view.Detalles)
                    {
                        detalle.Id_venta_cabecera = idCabecera;
                        detalleRepo.Add(detalle);

                        // Actualizar stock del producto
                        var producto = productoRepo.GetAll().First(p => p.Id_libro == detalle.Id_libro);
                        producto.Stock -= detalle.Cantidad;
                        productoRepo.Modificar(producto);
                    }

                    transaction.Complete();
                }

                view.MostrarMensaje($"Venta finalizada exitosamente. N°: {view.NumeroFactura}", true);
                view.LimpiarDetalles();

                // Generar nuevo número de factura
                view.NumeroFactura = ventaCabeceraRepository.ObtenerProximoNumeroFactura().ToString();

            }
            catch (Exception ex)
            {
                view.MostrarMensaje($"Error al finalizar venta: {ex.Message}", false);
            }
        }

        private void OnCancelarVenta(object sender, EventArgs e)
        {
            view.LimpiarDetalles();
            view.TotalVenta = 0;
            view.MostrarMensaje("Venta cancelada", true);
        }

        private void ActualizarTotalVenta()
        {
            decimal total = view.Detalles.Sum(d => d.Subtotal);
            view.TotalVenta = total;
        }
        private void AbrirVistaCliente(object sender, EventArgs e)
        {
            try
            {
                // Obtener el contenedor padre (MdiParent) usando la propiedad FormInstance de la interfaz
                //Form parentContainer = this.view.FormInstance;
                Form parentContainer = this.view.FormInstance.MdiParent;

                // Obtener la instancia ÚNICA de la vista de Cliente (Singleton)
                IVendedorCliente clienteView = VendedorViewCliente.GetInstance(parentContainer);

                //  Crear el Repositorio de Cliente (usando la conexión almacenada)
                IClienteRepository clienteRepository = new ClienteRepository(this.connectionString);

                //  Inicializar el Presenter de Cliente
                new VendedorClientePresenter(clienteView, clienteRepository);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir la vista de clientes: {ex.Message}", "Error de Navegación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarClientePorCuit(object sender, EventArgs e)
        {
            try
            {
                // VERIFICAR que el repositorio no sea null
                if (clienteRepository == null)
                {
                    MessageBox.Show("Error: Repositorio de clientes no inicializado", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string cuit = view.ClienteCuit?.Trim();

                // Solo buscar si el CUIT tiene al menos 8 caracteres (para evitar búsquedas prematuras)
                if (string.IsNullOrEmpty(cuit) || cuit.Length < 8)
                {
                    LimpiarDatosCliente();
                    return;
                }

                // Buscar cliente en la base de datos
                var cliente = clienteRepository.ObtenerPorCuit(cuit);

                if (cliente != null)
                {
                    // Autocompletar los datos del cliente
                    view.ClienteNombre = cliente.Nombre_razon_social;
                    view.ClienteEmail = cliente.Email;
                    view.ClienteTelefono = cliente.Telefono;
                }
                else
                {
                    // Cliente no encontrado, limpiar campos
                    LimpiarDatosCliente();
                    MessageBox.Show("Cliente no encontrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar cliente: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCliente(object sender, EventArgs e)
        {
            try
            {
                // Limpiar todos los campos del cliente
                view.ClienteNombre = string.Empty;
                view.ClienteCuit = string.Empty;
                view.ClienteEmail = string.Empty;
                view.ClienteTelefono = string.Empty;

                // Opcional: Mostrar mensaje de confirmación
                MessageBox.Show("Datos del cliente limpiados correctamente", "Información",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al limpiar datos del cliente: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarDatosCliente()
        {
            view.ClienteNombre = string.Empty;
            view.ClienteEmail = string.Empty;
            view.ClienteTelefono = string.Empty;
        }

        private void BuscarVendedorPorCuit(object sender, EventArgs e)
        {
            try
            {
                string cuit = view.VendedorCuit?.Trim();

                // Solo buscar si el CUIT tiene al menos 8 caracteres
                if (string.IsNullOrEmpty(cuit) || cuit.Length < 8)
                {
                    LimpiarDatosVendedor();
                    return;
                }

                // Buscar vendedor en la base de datos
                var vendedor = usuarioRepository.ObtenerPorCuit(cuit);

                if (vendedor != null && vendedor.EstaActivo && vendedor.Id_rol == 3) // Verificar que esté activo y rol vendedor
                {
                    // Autocompletar los datos del vendedor
                    view.VendedorNombre = $"{vendedor.Nombre} {vendedor.Apellido}";
                }
                else
                {
                    // Vendedor no encontrado o inactivo, limpiar campos
                    LimpiarDatosVendedor();
                    if (vendedor != null && !vendedor.EstaActivo)
                    {
                        MessageBox.Show("El vendedor está inactivo", "Información",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Vendedor no encontrado", "Información",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar vendedor: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Mostrar búsqueda de productos en un diálogo
        private void MostrarBusquedaProductos()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(view.ProductoBusqueda))
                {
                    view.MostrarMensaje("Ingrese un término de búsqueda", false);
                    return;
                }

                // Buscar productos
                var productos = productoRepo.GetByValueTitulo(view.ProductoBusqueda)
                                .Concat(productoRepo.GetByValueCategoria(view.ProductoBusqueda))
                                .Where(p => p.Stock > 0 && p.Eliminado_id == 0)
                                .Distinct()
                                .ToList();

                if (!productos.Any())
                {
                    view.MostrarMensaje("No se encontraron productos", false);
                    return;
                }

                // Mostrar diálogo de selección
                using (var searchForm = new ProductoSearchView(productos))
                {
                    if (searchForm.ShowDialog() == DialogResult.OK && searchForm.ProductoSeleccionado != null)
                    {
                        var producto = searchForm.ProductoSeleccionado;

                        // Cargar datos del producto seleccionado en el formulario de venta
                        view.ProductoSeleccionadoId = producto.Id_libro;
                        view.ProductoSeleccionadoNombre = producto.Titulo;
                        view.ProductoSeleccionadoCategoria = producto.Editorial;
                        view.ProductoPrecio = producto.Precio; 
                        view.ProductoSeleccionadoStock = producto.Stock.ToString();
                        CalcularYActualizarSubtotal();

                        decimal subtotalInicial = view.ProductoCantidad * view.ProductoPrecio;
                        view.ProductoSeleccionadoSubtotal = subtotalInicial;
                        view.MostrarMensaje($"Producto '{producto.Titulo}' seleccionado", true);
                    }
                }
            }
            catch (Exception ex)
            {
                view.MostrarMensaje($"Error al buscar productos: {ex.Message}", false);
            }
        }

        //MÉTODO PARA MANEJAR CAMBIOS
        private void OnCantidadOPrecioCambiado(object sender, EventArgs e)
        {
            CalcularYActualizarSubtotal();
        }

        // MÉTODO PARA CALCULAR Y ACTUALIZAR AUTOMÁTICAMENTE
        private void CalcularYActualizarSubtotal()
        {
            try
            {
                decimal precio = view.ProductoPrecio;
                int cantidad = view.ProductoCantidad;
                decimal subtotal = cantidad * precio;
                view.ProductoSeleccionadoSubtotal = subtotal;
            }
            catch (Exception ex)
            {
                // No mostrar mensaje para no molestar al usuario durante la escritura
                view.ProductoSeleccionadoSubtotal = 0;
            }
        }

        // Limpiar datos del vendedor
        private void LimpiarDatosVendedor()
        {
            view.VendedorNombre = string.Empty;
        }
        // Cargar el próximo número de factura
        private void CargarProximoNumeroFactura()
        {
            try
            {
                int proximoNumero = ventaCabeceraRepository.ObtenerProximoNumeroFactura();
                view.NumeroFactura = proximoNumero.ToString("D8"); // Formato de 8 dígitos
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar número de factura: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                view.NumeroFactura = "1";
            }
        }

        // 


    }
}

