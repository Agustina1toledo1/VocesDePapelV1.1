using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Views;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Repositories;

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
            this.view.AddNewDetalleEvent += AddNewDetalle;
            this.view.AddNewEvent += AddNewVenta;
            this.view.SaveEvent += SaveVenta;
            this.view.DeleteAllEvent += DeleteAllDetalles;
            this.view.DeleteEvent += DeleteDetalle;
            this.view.CancelAllEvent += CancelAll;
            this.view.CalculateSubtotalEvent += CalcularSubtotal;

            //suscribir eventos de la vista productoSearchView
            // this.productoSearchView.SelectEvent += ProductoSelected;
            //this.productoSearchView.CancelEvent += ProductoSearchCanceled;

            this.view.Show();


        }

        private void ProductoSearchCanceled(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /*private void ProductoSelected(object? sender, EventArgs e)
        {
            if (productoSearchView is Form form && form.Controls["dtg_productoSearch"] is DataGridView dgv && dgv.CurrentRow != null)
            {
                var producto = dgv.CurrentRow.DataBoundItem as ProductoModel;
                if (producto != null)
                {
                    view.Id_producto = producto.Id_libro.ToString();
                    view.Producto_nombre = producto.Titulo;
                    view.Producto_stock = producto.Stock.ToString();
                    view.Precio_unitario = producto.Precio.ToString();
                    view.Subtotal = (producto.Precio * Convert.ToInt32(view.Cantidad)).ToString();
                    view.Message = "Producto seleccionado.";
                    view.IsSuccessful = true;
                }
            }
        }*/

        private void CancelAll(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteDetalle(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteAllDetalles(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveVenta(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewVenta(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewDetalle(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
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
                    this.view.Message = "El CUIT/CUIL ingresado no está registrado.";
                    CleanviewFieldsVendedor();
                    return;
                }
                else
                {
                    this.view.Vendedor_nombre = vendedor.NombreCompleto;
                    this.view.Id_usuario = vendedor.Id_usuario.ToString(); //se guarda internamente
                    this.view.Message = "Vendedor registrado.";
                    return;
                }
            }
            else
            {
                this.view.Message = "El CUIT/CUIL no puede estar vacío.";
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
                    this.view.Message = "El CUIT/CUIL ingresado no está registrado.";
                    CleanviewFieldsCliente();
                    return;
                }
                else
                {
                    this.view.Cliente_nombre = cliente.Nombre_razon_social;
                    this.view.Id_cliente = cliente.Id_cliente.ToString(); //se guarda internamente
                    this.view.Cliente_email = cliente.Email;
                    this.view.Cliente_telefono = cliente.Telefono;
                    this.view.Message = "Cliente registrado.";
                    return;
                }
            }
            else
            {
                this.view.Message = "El CUIT/CUIL no puede estar vacío.";
                CleanviewFieldsCliente();
            }
        }
        private void CalcularSubtotal(object? sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(this.view.Cantidad);

            if (cantidad > int.Parse(view.Producto_stock))
            {
                view.Message = "La cantidad supera el stock disponible.";
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
        }
        private void CleanviewFieldsVendedor()
        {
            this.view.Vendedor_nombre = "";
            this.view.Id_usuario = "0"; 
        }
    }
}
