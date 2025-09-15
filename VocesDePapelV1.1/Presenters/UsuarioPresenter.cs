using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Views;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Presenters
{
    public class UsuarioPresenter
    {
        //campos        
        private IGerenteViewUsuario view; //campo privado para la vista usando la interfaz
        private IUsuarioRepository repository; //campo privado para el repositorio usando la interfaz
        private BindingSource usuarioBindingSource; //origen de datos para el enlace
        private IEnumerable<UsuarioModel> usuarioList; //lista de usuarios

        //constructor
        public UsuarioPresenter(IGerenteViewUsuario view, IUsuarioRepository repository)
        {
            //inicializamos los campos
            this.usuarioBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //Suscribimos los eventos del controlador a los eventos de la vista
            this.view.SearchEvent += SearchUsuario;
            this.view.AddNewEvent += AddNewUsuario;
            this.view.EditEvent += EditUsuario;
            this.view.DeleteEvent += DeleteUsuario;
            this.view.SaveEvent += SaveUsuario;
            this.view.CancelEvent += CancelAction;
            //Establecemos el origen de datos del enlace, fuente vinculante
            this.view.SetUsuarioListBindingSource(usuarioBindingSource);
            //cargamos los datos de usuario a  la lista de usuarios
            LoadAllUsuarioList();
            //mostramos la vista
            this.view.Show();
        }

        private void LoadAllUsuarioList()
        {
            usuarioList = repository.GetAll(); //obtenemos todos los usuarios del repositorio
            usuarioBindingSource.DataSource = usuarioList; //establecemos la lista de usuarios como el origen de datos del enlace
        }
        private void SearchUsuario(object? sender, EventArgs e)
        {
            //si es vacio, nulo, espacio en blanco
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if(emptyValue == false) //si no es vacio
            {
                usuarioList = repository.GetByValue(this.view.SearchValue); //obtenemos los usuarios que coinciden con el valor de busqueda
            }
            else
            {
                usuarioList = repository.GetAll(); //si es vacio, obtenemos todos los usuarios
            }
            //actualizamos el origen de datos del enlace
            usuarioBindingSource.DataSource = usuarioList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveUsuario(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteUsuario(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditUsuario(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewUsuario(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        
    }
}
