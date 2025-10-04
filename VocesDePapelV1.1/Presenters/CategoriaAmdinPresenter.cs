using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Views;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Presenters.Common;
using VocesDePapelV1._1.Servicios;
using VocesDePapelV1._1.Repositories;

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

        private void LoadAllCategoriaList()
        {
            throw new NotImplementedException();
        }

        private void CargarAllEstado()
        {
            throw new NotImplementedException();
        }

        private void SaveCategoria(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditCategoria(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteCategoria(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewCategoria(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchCategoria(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
