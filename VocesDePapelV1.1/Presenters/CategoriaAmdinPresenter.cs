using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Views;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Presenters.Common;
using VocesDePapelV1._1.Servicios;

namespace VocesDePapelV1._1.Presenters
{
    public class CategoriaAmdinPresenter
    {
        //campos     
        private IAdministradorCategoria view; //campo privado para la vista usando la interfaz
        private ICategoriaRepository repository; //campo privado para el repositorio usando la interfaz
        private IContraseniaHasher hasher; //campo privado para el hasher usando la interfaz
        private BindingSource usuarioBindingSource; //origen de datos para el enlace
        private BindingSource estadoBindingSource; //origen de datos para el enlace
        private BindingSource rolBindingSource; //origen de datos para el enlace
        private IEnumerable<UsuarioModel> usuarioList; //lista de usuarios
        private IEnumerable<RolModel> rolList;
        private IEnumerable<EstadoModel> estadoList;
        public CategoriaAmdinPresenter(IAdministradorCategoria view)
        {
            this.view = view;
            //mostramos la vista
            this.view.Show();
        }
    }
}
