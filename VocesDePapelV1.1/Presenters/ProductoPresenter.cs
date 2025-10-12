using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Views;
using VocesDePapelV1._1.Servicios;
using VocesDePapelV1._1.Presenters.Common;
using VocesDePapelV1._1.Repositories;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Presenters
{
    public class ProductoPresenter
    {
        //instanciamos los campos
        private IAdministradorViewProducto view;
        private IProductoRepository repository;
        private BindingSource productoBindingSource;
        private BindingSource categoriaBindingSource;
        private BindingSource estadoBindingSource;
        private IEnumerable<ProductoModel> productoList;
        private IEnumerable<CategoriaModel> categoriaList;
        private IEnumerable<EstadoModel> estadoList;


        public ProductoPresenter(IAdministradorViewProducto view, IProductoRepository repository)
        {
            //inicializamos los campos
            this.productoBindingSource = new BindingSource();
            this.categoriaBindingSource = new BindingSource();
            this.estadoBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            //suscribimos eventos
            this.view.SearchEvent += SearchProducto;
            this.view.AddNewEvent += AddNewProducto;
            this.view.EditEvent += EditProducto;
            this.view.DeleteEvent += DeleteProducto;
            this.view.SaveEvent += SaveProducto;
            this.view.CancelEvent += CancelAction;

            //cargar los datos
            CargarAllEstado();
            CargarAllCategoria();
            CargarAllProductos();

            //enlazamos los datos
            this.view.SetProductoListBindingSource(productoBindingSource);
            this.view.SetCategoriaListBindingSource(categoriaBindingSource);
            this.view.SetEstadoListBindingSource(estadoBindingSource);
            //mostramos la vista
            this.view.Show();
        }

        private void CargarAllProductos()
        {
            productoList = repository.GetAll();

            foreach (var producto in productoList)
            {
                var categoria = repository.GetCategoria().FirstOrDefault(c => c.Id_categoria == producto.Id_categoria);
                if (categoria != null)
                {
                    producto.Nombre_categoria= categoria.Nombre_categoria;
                }
                var estado = repository.GetEstado().FirstOrDefault(e => e.Id_estado == producto.Eliminado_id);
                if (estado != null)
                {
                    producto.Nombre_estado= estado.Nombre_estado;
                }
            }
        }

        private void CargarAllCategoria()
        {
            categoriaList = repository.GetCategoria();
            categoriaBindingSource.DataSource = categoriaList;
        }

        private void CargarAllEstado()
        {
            estadoList = repository.GetEstado();
            estadoBindingSource.DataSource = estadoList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanviewFields();
        }

        private void CleanviewFields()
        {
            view.ProductoTitulo = "";
            view.ProductoEditorial = "";
            view.ProductoPrecio = "";
            view.ProductoStock = "";

        }

        private void SaveProducto(object? sender, EventArgs e)
        {
            var producto = new ProductoModel();

            producto.Id_libro = Convert.ToInt32(view.ProductoId);
            producto.Titulo = view.ProductoTitulo.ToString();
            producto.Editorial = view.ProductoEditorial.ToString();
            producto.Precio = Convert.ToSingle(view.ProductoPrecio);
            producto.Stock = Convert.ToInt32(view.ProductoStock);
            producto.Eliminado_id = Convert.ToInt32(view.ProductoEliminado);
            producto.Id_categoria = Convert.ToInt32(view.ProductoIdCategoria);

            try
            {
                new Common.ModelDataValidation().Validate(producto);
                repository.Modificar(producto);
                view.Message = "Producto modificado correctamente";
                view.IsSuccessful = "True";
                CargarAllProductos();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = "False";
                view.Message = ex.Message;
            }
        }

        private void DeleteProducto(object? sender, EventArgs e)
        {
            try
            {
                var producto = new ProductoModel();
                repository.Eliminar(producto.Id_libro);
                view.IsSuccessful = "True";
                view.Message = "Producto eliminado correctamente";
                CargarAllProductos();
            }catch (Exception ex)
            {
                view.IsSuccessful = "False";
                view.Message = ex.Message;
            }
        }

        private void EditProducto(object? sender, EventArgs e)
        {
            var producto =(ProductoModel)productoBindingSource.Current;

            view.ProductoId = producto.Id_libro.ToString();
            view.ProductoTitulo = producto.Titulo;
            view.ProductoEditorial = producto.Editorial;
            view.ProductoPrecio = producto.Precio.ToString();
            view.ProductoStock = producto.Stock.ToString();
            view.ProductoNombreEstado = producto.Nombre_estado;
            view.ProductoNombreCategoria = producto.Nombre_categoria;
        }

        private void AddNewProducto(object? sender, EventArgs e)
        {
            var producto = new ProductoModel();

            producto.Titulo = view.ProductoTitulo;
            producto.Editorial = view.ProductoEditorial;
            producto.Precio = Convert.ToSingle(view.ProductoPrecio);
            producto.Stock = Convert.ToInt32(view.ProductoStock);
            producto.Eliminado_id = Convert.ToInt32(view.ProductoEliminado);
            producto.Id_categoria = Convert.ToInt32(view.ProductoIdCategoria);

            try
            {
                new Common.ModelDataValidation().Validate(producto);
                repository.Add(producto);
                view.Message = "Producto agregado correctamente";
                view.IsSuccessful = "True";
                CargarAllProductos();
            }catch (Exception ex)
            {
                view.IsSuccessful = "False";
                view.Message = ex.Message;
                return;

            }
        }

        private void SearchProducto(object? sender, EventArgs e)
        {
            
        }
    }
}
