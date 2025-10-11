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
    public class AutoresAdminPresenter
    {
        private IAdministradorAutor view; //campo privado para la vista usando la interfaz
        private IAutorRepository repository; //campo privado para el repositorio usando la interfaz
        private BindingSource autorBindingSource; //origen de datos para el enlace
        private BindingSource estadoBindingSource; //origen de datos para el enlace
        private IEnumerable<AutorModel> autorList; //lista de usuarios
        private IEnumerable<EstadoModel> estadoList;

        public AutoresAdminPresenter(IAdministradorAutor view, IAutorRepository repository)
        {
            this.autorBindingSource = new BindingSource();
            this.estadoBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            

            //suscribimos los eventos del controlador a los eventos de la vista
            this.view.SearchEvent += SearchAutor;
            this.view.AddNewEvent += AddNewAutor;
            this.view.EditEvent += EditAutor;
            this.view.DeleteEvent += DeleteAutor;
            this.view.SaveEvent += SaveAutor;
            this.view.CancelEvent += CancelAction;

            //cargar los datos de estado 
            CargarAllEstado();
            //cargamos los datos de usuario a  la lista de usuarios
            LoadAllAutoresList();
            //Establecemos el origen de datos del enlace, fuente vinculante
            this.view.SetAutorListBindingSource(autorBindingSource);
            this.view.SetEstadoListBindingSource(estadoBindingSource);
            
            //mostramos la vista
            this.view.Show();
        }

        private void LoadAllAutoresList()
        {
            autorList = repository.GetAll(); //obtenemos todos las categorias del repositorio
            foreach (var categoria in autorList)
            {
                var estado = estadoList.FirstOrDefault(e => e.Id_estado == categoria.Estado_id);

                categoria.Nombre_estado = estado?.Nombre_estado ?? "Desconocido";
            }
            autorBindingSource.DataSource = autorList;
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

        private void SaveAutor(object? sender, EventArgs e) //modificar autor
        {
            var autor = new AutorModel();
            autor.Alias_autor = Convert.ToString(view.AliasAutor);
            autor.Alias_autor = view.AliasAutor;
            autor.Estado_id = Convert.ToInt32(view.Estado_id);

            try
            {
                new Common.ModelDataValidation().Validate(autor);
                repository.Modificar(autor);
                view.Message = "Autor modificado exitosamente";
                view.IsSuccessful = true;
                //LoadAllAutorList(); //recargamos la lista de autores
            }
            catch (Exception ex)
            {
                this.view.IsSuccessful = false;
                this.view.Message = ex.Message;
                return;
            }
        }

        private void DeleteAutor(object? sender, EventArgs e)
        {
            try
            {
                var autor = (AutorModel)autorBindingSource.Current;
                repository.Eliminar(autor.Id_autor);
                view.Message = "Autor eliminado exitosamente";
                view.IsSuccessful = true;
                //LoadAllAutorList(); //recargamos la lista de autores
            }
            catch (Exception ex)
            {
                this.view.IsSuccessful = false;
                this.view.Message = ex.Message;
                return;
            }
        }

        private void EditAutor(object? sender, EventArgs e) //coloca los datos del autor seleccionado en los campos de la vista
        {
            var autor = (AutorModel)autorBindingSource.Current;

            view.AutorId = autor.Id_autor.ToString();
            view.AliasAutor = autor.Alias_autor;
            view.Estado_id = autor.Estado_id.ToString();
        }

        private void AddNewAutor(object? sender, EventArgs e)
        {
            var autor = new AutorModel();
            autor.Alias_autor = view.AliasAutor;
            autor.Estado_id = Convert.ToInt32(view.Estado_id);

            try
            {
                new Common.ModelDataValidation().Validate(autor);
                repository.Add(autor);
                view.Message = "Autor agregado exitosamente";
                view.IsSuccessful = true;
                //LoadAllAutorList(); //recargamos la lista de autores
            }
            catch (Exception ex)
            {
                this.view.IsSuccessful = false;
                this.view.Message = ex.Message;
                return;
            }
        }

        private void SearchAutor(object? sender, EventArgs e)
        {
            //si es vacio, nulo, espacio en blanco
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);

            if (emptyValue == false)
            {
                autorList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                autorList = repository.GetAll(); //obtener todos los autores
            }
            //asignamos el nombre del estado a cada autor
            foreach (var autor in autorList)
            {
                var estado = estadoList.FirstOrDefault(e => e.Id_estado == autor.Estado_id);
                
                autor.Nombre_estado = estado?.Nombre_estado?? "Desconocido";
                
            }
            //actualizamos el origen de datos del enlace
            autorBindingSource.DataSource = autorList;
        }
        private void CleanviewFields()
        {

            view.AliasAutor = "";

        }
    }
}
