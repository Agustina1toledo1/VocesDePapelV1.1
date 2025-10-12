using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Presenters.Common;
using VocesDePapelV1._1.Servicios;
using VocesDePapelV1._1.Views;
using VocesDePapelV1._1.Repositories;

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
                var categoria = categoriaList.FirstOrDefault(c => c.Id_categoria == producto.Id_categoria);
                var estado = estadoList.FirstOrDefault(e => e.Id_estado == producto.Eliminado_id);
                
                producto.Nombre_categoria = categoria?.Nombre_categoria ?? "Desconocida";
                producto.Nombre_estado = estado?.Nombre_estado ?? "Desconocido";
            }
            productoBindingSource.DataSource = productoList;
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
            producto.Titulo = view.ProductoTitulo;
            producto.Editorial = view.ProductoEditorial;
            producto.Precio = Convert.ToSingle(view.ProductoPrecio);
            producto.Stock = Convert.ToInt32(view.ProductoStock);
            producto.Eliminado_id = Convert.ToInt32(view.ProductoEliminado);
            producto.Id_categoria = Convert.ToInt32(view.ProductoIdCategoria);

            try
            {
                new Common.ModelDataValidation().Validate(producto);
                repository.Modificar(producto);
                view.Message = "Producto modificado correctamente";
                view.IsSuccessful = true;
                CargarAllProductos();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void DeleteProducto(object? sender, EventArgs e)
        {
            try
            {
                var producto = (ProductoModel)productoBindingSource.Current;//obtenemos el usuario actual del origen de datos del enlace
                repository.Eliminar(producto.Id_libro);
                view.IsSuccessful = true;
                view.Message = "Producto eliminado correctamente";
                CargarAllProductos();
            }catch (Exception ex)
            {
                view.IsSuccessful = false;
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
            producto.Precio = float.Parse(view.ProductoPrecio);
            producto.Stock = Convert.ToInt32(view.ProductoStock);
            producto.Eliminado_id = Convert.ToInt32(view.ProductoEliminado);
            producto.Id_categoria = Convert.ToInt32(view.ProductoIdCategoria);

            try
            {
                new Common.ModelDataValidation().Validate(producto);
                repository.Add(producto);
                view.Message = "Producto agregado correctamente";
                view.IsSuccessful = true;
                CargarAllProductos();
            }catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
                return;

            }
        }

        private void SearchProducto(object? sender, EventArgs e)
        {
            string searchBy = this.view.SearchBy;
            string searchValue = this.view.SearchValue;
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);

            if (emptyValue == false )
            {
                switch (searchBy)
                {
                    case "Titulo":
                        productoList = repository.GetByValueTitulo(searchValue);
                        break;
                    case "Categoria":
                        productoList = repository.GetByValueCategoria(searchValue);
                        break;
                    default:
                        productoList = repository.GetAll();
                        break;
                }
            }
            else
            {
                productoList = repository.GetAll();
            }
            foreach (var producto in productoList)
            {
                var categoria = categoriaList.FirstOrDefault(c => c.Id_categoria == producto.Id_categoria);
                var estado = estadoList.FirstOrDefault(e => e.Id_estado == producto.Eliminado_id);
                producto.Nombre_categoria = categoria?.Nombre_categoria ?? "Desconocida";
                producto.Nombre_estado = estado?.Nombre_estado ?? "Desconocido";
            }
            productoBindingSource.DataSource = productoList;

        }
    }
}
