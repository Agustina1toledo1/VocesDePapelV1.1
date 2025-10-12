using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Repositories;
using VocesDePapelV1._1.Views;

namespace VocesDePapelV1._1.Presenters
{
    public class VendedorVentaPresenter
    {
        private IVendedorVenta view; //campo privado para la vista usando la interfaz
        private readonly string connectionString; // Almacena la cadena de conexión
        private IClienteRepository clienteRepository; // Repositorio de Cliente para la busqueda
        private IUsuarioRepository usuarioRepository; // Repositorio para usuarios/vendedores
        private IVentaCabeceraRepository ventaCabeceraRepository; // Repositorio para la venta


        // Constructor
        public VendedorVentaPresenter(IVendedorVenta view, string connectionString)
        {
            this.view = view;
            this.connectionString = connectionString;
            this.clienteRepository = new ClienteRepository(connectionString);
            this.usuarioRepository = new UsuarioRepository(connectionString);
            this.ventaCabeceraRepository = new VentaCabeceraRepository(connectionString);
            this.view.AddNewClienteEvent += AbrirVistaCliente;
            this.view.SearchClienteByCuitEvent += BuscarClientePorCuit;
            this.view.ClearClienteEvent += LimpiarCliente;
            this.view.SearchVendedorByCuitEvent += BuscarVendedorPorCuit;
            this.view.ClearVentaEvent += LimpiarVentaCompleta;

            CargarProximoNumeroFactura(); // Cargar el próximo número de factura al iniciar
            this.view.Show();  //mostramos la vista
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
        // Limpiar datos del cliente
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
        // NUEVO MÉTODO: Limpiar toda la venta
        private void LimpiarVentaCompleta(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("¿Está seguro de limpiar toda la venta? Se perderán todos los datos ingresados.",
                                           "Confirmar Limpieza",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Limpiar datos del CLIENTE
                    view.ClienteNombre = string.Empty;
                    view.ClienteCuit = string.Empty;
                    view.ClienteEmail = string.Empty;
                    view.ClienteTelefono = string.Empty;

                    // Limpiar datos del VENDEDOR
                    view.VendedorNombre = string.Empty;
                    view.VendedorCuit = string.Empty;

                    // Limpiar datos de PRODUCTOS
                    /*view.CodigoProducto = string.Empty;
                    view.PrecioProducto = string.Empty;
                    view.StockProducto = string.Empty;
                    view.CantidadProducto = string.Empty;
                    view.PrecioTotal = string.Empty;*/

                    // Limpiar DataGridView de productos 
                    view.ProductosDataSource = null;

                    // Cargar nuevo número de factura
                    CargarProximoNumeroFactura();


                    MessageBox.Show("Venta limpiada correctamente", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al limpiar la venta: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
