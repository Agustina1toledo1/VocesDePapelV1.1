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
        private BindingSource categoriaEliminadaBindingSource;
        private BindingSource estadoBindingSource;
        private BindingSource autorBindingSource;
        private BindingSource autorEliminadoBindingSource;
        private IEnumerable<ProductoModel> productoList;
        private IEnumerable<CategoriaModel> categoriaList;
        private IEnumerable<CategoriaModel> categoriaEliminadaList;
        private IEnumerable<EstadoModel> estadoList;
        private IEnumerable<AutorModel> autorList;
        private IEnumerable<AutorModel> autorEliminadoList;


        public ProductoPresenter(IAdministradorViewProducto view, IProductoRepository repository)
        {
            //inicializamos los campos
            this.productoBindingSource = new BindingSource();
            this.categoriaBindingSource = new BindingSource();
            this.categoriaEliminadaBindingSource = new BindingSource();
            this.estadoBindingSource = new BindingSource();
            this.autorBindingSource = new BindingSource();
            this.autorEliminadoBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            //suscribimos eventos
            this.view.SearchEvent -= SearchProducto;
            this.view.SearchEvent += SearchProducto;

            this.view.AddNewEvent -= AddNewProducto;
            this.view.AddNewEvent += AddNewProducto;

            this.view.EditEvent -= EditProducto;
            this.view.EditEvent += EditProducto;

            this.view.DeleteEvent -= DeleteProducto;
            this.view.DeleteEvent += DeleteProducto;

            this.view.SaveEvent -= SaveProducto;
            this.view.SaveEvent += SaveProducto;

            this.view.CancelEvent -= CancelAction;
            this.view.CancelEvent += CancelAction;

            //cargar los datos
            CargarAllEstado();
            CargarAllCategoria();
            CargarAllAutor();
            CargarAllProductos();

            //enlazamos los datos
            this.view.SetProductoListBindingSource(productoBindingSource);
            this.view.SetCategoriaListBindingSource(categoriaBindingSource);
            this.view.SetEstadoListBindingSource(estadoBindingSource);
            this.view.SetAutorListBindingSource(autorBindingSource);
            //mostramos la vista
            this.view.Show();
        }

        private void CargarAllAutor()
        {
            var autorEliminado = new AutorModel()
            {
                Id_autor = 99,
                Alias_autor = "Autor eliminado",
                Estado_id = 0
            };
            autorList = repository.GetAutor();
            autorBindingSource.DataSource =autorList;
            autorEliminadoList = repository.GetAutor().Append(autorEliminado);
            autorEliminadoBindingSource.DataSource = autorEliminadoList;
        }

        private void CargarAllProductos()
        {
            productoList = repository.GetAll();
            
            productoBindingSource.DataSource = productoList;
        }


        private void CargarAllCategoria()
        {
            var categoriaEliminada = new CategoriaModel()
            {
                Id_categoria = 99,
                Nombre_categoria = "Categoría eliminada",
                Estado_id = 0
            };
            categoriaList = repository.GetCategoria();
            categoriaBindingSource.DataSource = categoriaList; //.Where(c => c.Estado_id == 0).ToList()
            categoriaEliminadaList = repository.GetCategoria().Append(categoriaEliminada);
            categoriaEliminadaBindingSource.DataSource = categoriaEliminadaList;

        }
       
        private void CargarAllEstado()
        {
            estadoList = repository.GetEstado();
            estadoBindingSource.DataSource = estadoList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            this.view.IsEdit = false;
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
            
            try
            {
                var producto = new ProductoModel();
                //tratamiento del campo precio, al ser decimal puede generar errores si el formato no es correcto
                if (string.IsNullOrWhiteSpace(view.ProductoStock) || !int.TryParse(view.ProductoStock, out var stock))
                {
                    producto.Stock = -1;
                }
                else
                {
                    producto.Stock = Convert.ToInt32(view.ProductoStock);
                }
                if (string.IsNullOrWhiteSpace(view.ProductoPrecio) || !decimal.TryParse(view.ProductoPrecio, out var precio))
                {
                    producto.Precio = -1;
                }
                else
                {
                    producto.Precio = Convert.ToDecimal(view.ProductoPrecio);
                }
                producto.Titulo = view.ProductoTitulo;
                producto.Editorial = view.ProductoEditorial;
                producto.Eliminado_id = Convert.ToInt32(view.ProductoEliminado);
                producto.Id_categoria = Convert.ToInt32(view.ProductoIdCategoria);
                producto.Id_autor = Convert.ToInt32(view.ProductoIdAutor);

                //new Common.ModelDataValidation().Validate(producto);
                if (this.view.IsEdit)
                {
                    

                    producto.Id_libro = Convert.ToInt32(view.ProductoId);
                    new Common.ModelDataValidation().Validate(producto);

                    repository.Modificar(producto);
                    view.Message = "Producto modificado correctamente";
                    view.IsSuccessful = true;
                    CargarAllProductos();
                   
                }
                else
                {
                    var existe = productoList.Any(p => p.Titulo == producto.Titulo);

                    if (existe)
                    {
                        view.Message = "Ya existe un producto con ese título.";
                        view.IsSuccessful = false;
                        return;
                    }
                    else
                    {
                        new Common.ModelDataValidation().Validate(producto);
                        repository.Add(producto);
                        view.Message = "Producto agregado correctamente";
                        view.IsSuccessful = true;
                        CargarAllProductos();
                    }

                }
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
                return;

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

            this.view.IsEdit = true;
            var producto =(ProductoModel)productoBindingSource.Current;
            // Verificar si la categoría está eliminada
            var categoria = categoriaList.FirstOrDefault(c => c.Id_categoria == producto.Id_categoria);
            var autor = autorList.FirstOrDefault(a => a.Id_autor == producto.Id_autor);

            view.ProductoId = producto.Id_libro.ToString();
            view.ProductoTitulo = producto.Titulo;
            view.ProductoEditorial = producto.Editorial;
            view.ProductoPrecio = producto.Precio.ToString();
            view.ProductoStock = producto.Stock.ToString();
            view.ProductoNombreEstado = producto.Nombre_estado;
            //si categoria no esta en la lista de categorias, significa que esta eliminada
            if (categoria == null)
            {
                var categoriaEliminada = categoriaEliminadaList.FirstOrDefault(c => c.Id_categoria == 99);
                this.view.SetCategoriaListBindingSource(categoriaEliminadaBindingSource);
                view.ProductoNombreCategoria = categoriaEliminada.Nombre_categoria;
            }
            else
            {
                this.view.SetCategoriaListBindingSource(categoriaBindingSource);
                view.ProductoNombreCategoria = producto.Nombre_categoria;
            }
            if (autor == null)
            {
                var autorEliminado = autorEliminadoList.FirstOrDefault(a => a.Id_autor == 99);
                this.view.SetAutorListBindingSource(autorEliminadoBindingSource);
                view.ProductoNombreAutor = autorEliminado.Alias_autor;
            }
            else
            {
                this.view.SetAutorListBindingSource(autorBindingSource);
                view.ProductoNombreAutor = producto.Nombre_autor;
            }

        }

        private void AddNewProducto(object? sender, EventArgs e)
        {
            this.view.IsEdit = false;
           
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
            
            productoBindingSource.DataSource = productoList;

        }
    }
}
