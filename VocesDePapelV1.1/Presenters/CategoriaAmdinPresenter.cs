using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Presenters.Common;
using VocesDePapelV1._1.Repositories;
using VocesDePapelV1._1.Servicios;
using VocesDePapelV1._1.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace VocesDePapelV1._1.Presenters
{
    public class CategoriaAmdinPresenter
    {
        //campos     
        private IAdministradorCategoria view; //campo privado para la vista usando la interfaz
        private ICategoriaRepository repository; //campo privado para el repositorio usando la interfaz
        private BindingSource categoriaBindingSource; //origen de datos para el enlace
        private BindingSource estadoBindingSource; //origen de datos para el enlace
        private IEnumerable<CategoriaModel> categoriaList; //lista de usuarios
        private IEnumerable<EstadoModel> estadoList;
        public CategoriaAmdinPresenter(IAdministradorCategoria view, ICategoriaRepository repository)
        {
            //inicializamos los campos
            this.categoriaBindingSource = new BindingSource();
            this.estadoBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            //Suscribimos los eventos del controlador a los eventos de la vista
            this.view.SearchEvent += SearchCategoria;
            this.view.AddNewEvent += AddNewCategoria;
            this.view.EditEvent += EditCategoria;
            this.view.DeleteEvent += DeleteCategoria;
            this.view.SaveEvent += SaveCategoria;
            this.view.CancelEvent += CancelAction;

            //cargar los datos de estado 
            CargarAllEstado();
            //cargamos los datos de usuario a  la lista de usuarios
            LoadAllCategoriaList();
            //Establecemos el origen de datos del enlace, fuente vinculante
            this.view.SetCategoriaListBindingSource(categoriaBindingSource);
            this.view.SetEstadoListBindingSource(estadoBindingSource);
            //mostramos la vista
            this.view.Show();
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanviewFields();
        }

        private void LoadAllCategoriaList()
        {
            categoriaList = repository.GetAll(); //obtenemos todos las categorias del repositorio
            foreach (var categoria in categoriaList)
            {
                var estado = estadoList.FirstOrDefault(e => e.Id_estado == categoria.Estado_id);

                categoria.Nombre_estado = estado?.Nombre_estado ?? "Desconocido";
            }
            categoriaBindingSource.DataSource = categoriaList; //establecemos la lista de categoria como el origen de datos del enlace
        }

        private void CargarAllEstado()
        {
            estadoList = repository.GetEstado();
            estadoBindingSource.DataSource = estadoList;
        }

        private void SaveCategoria(object? sender, EventArgs e)
        {
            var categoria = new CategoriaModel(); //creamos una nueva instancia del modelo de usuario 
            categoria.Id_categoria = Convert.ToInt32(view.CategoriaId); 
            categoria.Nombre_categoria = view.NombreCategoria;
            categoria.Estado_id = Convert.ToInt32(view.Estado_id);
            try
            {
                //validamos el modelo
                new Common.ModelDataValidation().Validate(categoria);
                
                repository.Modificar(categoria); //modificamos el usuario
                view.Message = "Categoria modificado exitosamente";
                view.IsSuccessful = true;
                LoadAllCategoriaList(); //recargamos la lista de categoria
            }
            catch (Exception ex)
            {
                this.view.IsSuccessful = false;
                this.view.Message = ex.Message;
                return;

            }

        }

        private void EditCategoria(object? sender, EventArgs e)
        {
            var categoria = (CategoriaModel)categoriaBindingSource.Current; //obtenemos la categoria actual del origen de datos del enlace
                                                                      //asignamos los valores de la vista a las propiedades del modelo

            view.CategoriaId = categoria.Id_categoria.ToString();
            view.NombreCategoria= categoria.Nombre_categoria ;
            view.Estado_id = categoria.Estado_id.ToString();
            view.NombreEstado = categoria.Nombre_estado;
            
           
        }
        private void CleanviewFields()
        {
            view.NombreCategoria = "";
        }

        private void DeleteCategoria(object? sender, EventArgs e)
        {
            try
            {
                var categoria = (CategoriaModel)categoriaBindingSource.Current; //obtenemos la categeoria actual del origen de datos del enlace
                repository.Eliminar(categoria.Id_categoria ); //eliminamos el categoria
                view.IsSuccessful = true;
                view.Message = "Usuario eliminado exitosamente";
                LoadAllCategoriaList(); //recargamos la lista de categorias
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Error al eliminar el usuario. " + ex.Message;
            }
        }

        private void AddNewCategoria(object? sender, EventArgs e)
        {
            var categoria = new CategoriaModel(); //creamos una nueva instancia del modelo de usuario
                                              
            //asignamos los valores de la vista a las propiedades del modelo y el modelo con hash en lugar de texto plano
           
            categoria.Nombre_categoria = view.NombreCategoria;
            categoria.Estado_id = Convert.ToInt32(view.Estado_id);

            //capturamos los posible errores 
            try
            {
                //validamos el modelo
                new Common.ModelDataValidation().Validate(categoria);

                repository.Add(categoria); //agregamos la nueva categoria
                view.Message = "Categoria agregada exitosamente";

                view.IsSuccessful = true;
                LoadAllCategoriaList(); //recargamos la lista de categoria
            }
            catch (Exception ex)
            {
                this.view.IsSuccessful = false;
                this.view.Message = ex.Message;
                return;

            }
            //this.view.IsEdit = false; //establecemos la vista en modo no edicion
            //SaveUsuario(sender, e);
        }

        private void SearchCategoria(object? sender, EventArgs e)
        {

            //si es vacio, nulo, espacio en blanco
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false) //si no es vacio
            {
                categoriaList = repository.GetByValue(this.view.SearchValue); //obtenemos los usuarios que coinciden con el valor de busqueda
            }
            else
            {
                categoriaList = repository.GetAll(); //si es vacio, obtenemos todos los usuarios
            }
            //asignamos el nombre del estado a cada categoria
            foreach (var categoria in categoriaList)
            {
                var estado = estadoList.FirstOrDefault(e => e.Id_estado == categoria.Estado_id);

                categoria.Nombre_estado = estado?.Nombre_estado ?? "Desconocido";
            }
            //actualizamos el origen de datos del enlace
            categoriaBindingSource.DataSource = categoriaList;
        }
    }
}
