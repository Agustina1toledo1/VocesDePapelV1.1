using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Repositories;
using VocesDePapelV1._1.Views;

namespace VocesDePapelV1._1.Presenters
{
    public class VendedorVentaPresenter2
    {
        private IVentaView2 view;
        //private IProductoSearchView2 productoSearchView;
        private IVentaCabeceraRepository2 cabeceraRepository;
        private IVentaDetalleRepository2 detalleRepository;
        private IClienteRepository clienteRepository;
        private IProductoRepository productoRepository;
        private IUsuarioRepository usuarioRepository;
        private BindingSource bindingSourceCabecera;
        private BindingSource bindingSourceDetalle;
        private BindingSource bindingSourceProducto;
        private IEnumerable<VentaCabeceraModel2> ventaCabeceras;
        private IEnumerable<VentaDetalleModel2> ventaDetalles;
        private IEnumerable<ProductoModel> productos;

        public VendedorVentaPresenter2(IVentaView2 view, 
            IVentaCabeceraRepository2 cabeceraRepository,
            IVentaDetalleRepository2 detalleRepository, IClienteRepository clienteRepository,
            IProductoRepository productoRepository,
            IUsuarioRepository usuarioRepository)//IProductoSearchView2 productoSearchView,
        {
            this.view = view;
            //this.productoSearchView = productoSearchView;
            this.cabeceraRepository = cabeceraRepository;
            this.detalleRepository = detalleRepository;
            this.clienteRepository = clienteRepository;
            this.usuarioRepository = usuarioRepository;
            this.productoRepository = productoRepository;
            this.bindingSourceCabecera = new BindingSource();
            this.bindingSourceDetalle = new BindingSource();
            this.bindingSourceProducto = new BindingSource();


            //suscribir eventos de la vista view
            this.view.SearchClienteEvent += SearchCliente;
            this.view.SearchVendedorEvent += SearchVendedor;
            this.view.SearchProductoEvent += SearchProducto;

            this.view.AddNewDetalleEvent -= AddNewDetalle; //desuscribir para evitar multiples suscripciones
            this.view.AddNewDetalleEvent += AddNewDetalle;
            this.view.AddNewEvent += AddNewVenta;
            this.view.SaveEvent -= SaveVenta;
            this.view.SaveEvent += SaveVenta;
            this.view.DeleteEvent += DeleteDetalle;
            this.view.CancelAllEvent += CancelAll;
            this.view.CalculateSubtotalEvent += CalcularSubtotal;
            this.view.ClearClienteEvent += CleanCliente;
            this.view.ClearProductoEvent += CleanProducto;

            this.ventaDetalles = new List<VentaDetalleModel2>();

            this.view.Show();


        }

        private void CleanProducto(object? sender, EventArgs e)
        {
            CleanviewFieldsProducto();
        }

        private void CleanCliente(object? sender, EventArgs e)
        {
            CleanviewFieldsCliente();
        }

        private void CancelAll(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteDetalle(object? sender, EventArgs e)
        {
            try
            {
                var detalle = (VentaDetalleModel2)bindingSourceDetalle.Current;
                if (detalle != null)
                {
                    var nuevaLista = ventaDetalles.ToList(); // convertir a lista
                    nuevaLista.Remove(detalle);
                    ventaDetalles = nuevaLista;
                    bindingSourceDetalle.DataSource = null;
                    bindingSourceDetalle.DataSource = ventaDetalles;
                    view.SetVentaDetalleListBindingSource(bindingSourceDetalle);

                    //actualizamos el total
                    decimal total = ventaDetalles.Sum(d => d.Subtotal);
                    this.view.Total_venta = total.ToString("0.00");
                    MessageBox.Show("Producto eliminado del detalle.");
                    view.IsSuccessful = true;
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el detalle: " + ex.Message);
                view.IsSuccessful = false;
            }
        }

       

        private void SaveVenta(object? sender, EventArgs e)
        {
            try
            {
                var ventaDetalleList = this.ventaDetalles?.ToList();
                if (string.IsNullOrWhiteSpace(view.Id_cliente) || view.Id_cliente == "0")
                {
                    MessageBox.Show("Debe buscar y seleccionar un cliente válido.");
                    view.IsSuccessful = false;
                    return;
                }else if (string.IsNullOrWhiteSpace(view.Id_usuario) || view.Id_usuario == "0")
                {
                    MessageBox.Show("Debe buscar y seleccionar un vendedor válido.");
                    view.IsSuccessful = false;
                    return;
                }
                else if (ventaDetalleList == null || ventaDetalleList.Count == 0)
                {
                    MessageBox.Show("No hay productos en el detalle.");
                    view.IsSuccessful = false;
                    return;
                }
                else
                {
                    var ventaCabecera = new VentaCabeceraModel2

                    {
                        Id_cliente = Convert.ToInt32(view.Id_cliente),
                        Id_usuario = Convert.ToInt32(view.Id_usuario),
                        // Fecha_venta = DateTime.Now,
                        Total_venta = Convert.ToDecimal(view.Total_venta)
                    };
                    new Common.ModelDataValidation().Validate(ventaCabecera);
                    cabeceraRepository.Add(ventaCabecera);

                    

                    foreach (var detalle in ventaDetalleList)
                    {
                        detalle.Id_venta_cabecera = ventaCabecera.Id_venta_cabecera; //asignar el id de la cabecera recien creada
                        new Common.ModelDataValidation().Validate(detalle);
                        detalleRepository.Add(detalle);

                        productoRepository.ActualizarStock(detalle.Id_libro, -(detalle.Cantidad));
                    }
                    int nroVenta = ventaCabecera.Id_venta_cabecera;
                    MessageBox.Show($"Venta NRO: {nroVenta}\n¡Guardada con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CleanviewFieldsVenta();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la venta: " + ex.Message);
                view.IsSuccessful = false;
                return;
            }
        }

        private void AddNewVenta(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        //Agregar nuevo detalle al datagrid de venta
        private void AddNewDetalle(object? sender, EventArgs e)
        {
            if (!int.TryParse(view.Cantidad, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show( "Cantidad inválida.");
                view.IsSuccessful = false;
                return;
            }

            if (!decimal.TryParse(view.Precio_unitario, out decimal precio) || precio <= 0)
            {
                MessageBox.Show( "Precio inválido.");
                view.IsSuccessful = false;
                return;
            }

            if (!int.TryParse(view.Producto_stock, out int stock) || cantidad > stock)
            {
                MessageBox.Show("La cantidad supera el stock disponible.");
                view.IsSuccessful = false;
                return;
            }
            int idProducto = int.Parse(view.Id_producto);

            // Verificar si el producto ya está en el detalle
            if (ventaDetalles.Any(d => d.Id_libro == idProducto))
            {
                MessageBox.Show("Este producto ya fue agregado al detalle.Elimine el producto y vuelva a agregar");
                view.IsSuccessful = false;
                return;
            }
            var detalle = new VentaDetalleModel2
            {
                Id_libro = Convert.ToInt32(view.Id_producto),
                Cantidad = Convert.ToInt32(view.Cantidad),
                Titulo_libro = view.Producto_nombre,
                Precio_unitario = precio,
                Subtotal = this.view.Subtotal != "" ? Convert.ToDecimal(this.view.Subtotal) : 0
            };
            //creamos una lista temporal de detalles de venta
            var nuevaLista = ventaDetalles.ToList(); // convertir a lista
            nuevaLista.Add(detalle);
            ventaDetalles = nuevaLista;

            bindingSourceDetalle.DataSource = null;
            bindingSourceDetalle.DataSource = ventaDetalles;
            view.SetVentaDetalleListBindingSource(bindingSourceDetalle);

            //actualizamos el total
            decimal total = ventaDetalles.Sum(d => d.Subtotal);
            this.view.Total_venta = total.ToString("0.00");

            MessageBox.Show("Producto agregado al detalle.");
            view.IsSuccessful = true;
        }


        private void SearchProducto(object? sender, EventArgs e)
        {
            var buscador = new ProductoSearchView2();
            string searchValue = this.view.SearchValue;
            bool emptyValue = string.IsNullOrWhiteSpace(searchValue);

            if (emptyValue == false) //si no es vacio
            {
                productos = productoRepository.GetByValueTitulo(searchValue); //obtenemos los productos que coinciden con el valor de busqueda
                if (productos == null || productos.Count() == 0)
                {
                    
                    MessageBox.Show("No se encontraron libros que coincidan con la búsqueda.");
                    return;
                }
                else
                {
                    bindingSourceProducto.DataSource = productos.Where(c => c.Eliminado_id == 0).ToList();
                    buscador.SetProductoListBindingSource(bindingSourceProducto); //libros activos 
                    buscador.Show();
                }

                // Manejo de selección
                buscador.SelectEvent += (s, e) =>
                {
                    if (buscador.Controls["dtg_productoSearch"] is DataGridView dgv && dgv.CurrentRow != null)
                    {
                        var producto = dgv.CurrentRow.DataBoundItem as ProductoModel;
                        if (producto != null)
                        {
                            view.Id_producto = producto.Id_libro.ToString();
                            view.Producto_nombre = producto.Titulo;
                            view.Producto_stock = producto.Stock.ToString();
                            view.Precio_unitario = producto.Precio.ToString();
                            view.Subtotal = (producto.Precio * Convert.ToInt32(view.Cantidad)).ToString();

                            view.IsSuccessful = true;
                        }
                    }
                    buscador.Close();
                };

            }
            else
            {
                MessageBox.Show("El campo de búsqueda no puede estar vacío.");
                
            }

        }

        private void SearchVendedor(object? sender, EventArgs e)
        {
            //si es vacio, nulo, espacio en blanco
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.Vendedor_cuit);
            if (emptyValue == false)
            {
                var vendedor = usuarioRepository.ObtenerPorCuit(this.view.Vendedor_cuit);
                if (vendedor == null)
                {
                    MessageBox.Show( "El CUIT/CUIL ingresado no está registrado.");
                    CleanviewFieldsVendedor();
                    return;
                }
                else
                {
                    this.view.Vendedor_nombre = vendedor.NombreCompleto;
                    this.view.Id_usuario = vendedor.Id_usuario.ToString(); //se guarda internamente
                    return;
                }
            }
            else
            {
                MessageBox.Show( "El CUIT/CUIL no puede estar vacío.");
                CleanviewFieldsVendedor();
            }
        }

        private void SearchCliente(object? sender, EventArgs e)
        {
            //si es vacio, nulo, espacio en blanco
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.Cliente_cuit);
            if (emptyValue == false)
            {
                var cliente = clienteRepository.ObtenerPorCuit(this.view.Cliente_cuit);
                if (cliente == null)
                {
                    MessageBox.Show("El CUIT/CUIL ingresado no está registrado.");
                    CleanviewFieldsCliente();
                    return;
                }
                else
                {
                    this.view.Cliente_nombre = cliente.Nombre_razon_social;
                    this.view.Id_cliente = cliente.Id_cliente.ToString(); //se guarda internamente
                    this.view.Cliente_email = cliente.Email;
                    this.view.Cliente_telefono = cliente.Telefono;
                    return;
                }
            }
            else
            {
                MessageBox.Show("El CUIT/CUIL no puede estar vacío.");
                CleanviewFieldsCliente();
            }
        }
        private void CalcularSubtotal(object? sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(this.view.Cantidad);

            if (cantidad > int.Parse(view.Producto_stock))
            {
                MessageBox.Show("La cantidad supera el stock disponible.");
                view.Subtotal = "0.00";
                return;
            }
            // Intentar convertir el texto del precio unitario
            try
            {
                decimal precioProducto = Convert.ToDecimal(this.view.Precio_unitario);
                decimal subtotal = cantidad * precioProducto;
                this.view.Subtotal = subtotal.ToString("0.00");

            }
            catch
            {
                MessageBox.Show("Precio unitario inválido. No se puede calcular el subtotal.");
            }
        }

        private void CleanviewFieldsCliente()
        {
            this.view.Cliente_nombre = "";
            this.view.Id_cliente = "0"; //se guarda internamente
            this.view.Cliente_email = "";
            this.view.Cliente_telefono = "";
            this.view.Cliente_cuit = "";
        }
        private void CleanviewFieldsVendedor()
        {
            this.view.Vendedor_nombre = "";
            this.view.Id_usuario = "0"; 
        }

        private void CleanviewFieldsProducto()
        {
            this.view.Id_producto = "0";
            this.view.Producto_nombre = "";
            this.view.Producto_stock = "0";
            this.view.Precio_unitario = "0.00";
            this.view.Subtotal = "0.00";
            this.view.SearchValue = "";


        }
        private void cleanViewFieldsDetalles()
        {
            ventaDetalles = new List<VentaDetalleModel2>(); // vaciar la lista
            bindingSourceDetalle.DataSource = null;
            bindingSourceDetalle.DataSource = ventaDetalles;
            view.SetVentaDetalleListBindingSource(bindingSourceDetalle);

            // limpiar el total
            view.Total_venta = "0.00";
        }
        private void CleanviewFieldsVenta()
        {
            CleanviewFieldsCliente();
            CleanviewFieldsProducto();
            cleanViewFieldsDetalles();
        }
    }
}
