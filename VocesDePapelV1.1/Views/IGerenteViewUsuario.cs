using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocesDePapelV1._1.Views
{
    public interface IGerenteViewUsuario
    {
        //propiedades
        string UsuarioId{ get; set; }
        string UsuarioNombre { get; set; }
        string UsuarioApellido { get; set; }
        string Clave { get; set; }
        string CuitUsuario { get; set; }
        bool Baja { get; set; }
        string UsuarioIdRol { get; set; }

        //Eventos
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Metodos
        //enlace a la lista de usuarios
        void SetUsuarioListBindingSource(BindingSource usuarioList);
        void Show(); //mostrar formulario
    }
}
