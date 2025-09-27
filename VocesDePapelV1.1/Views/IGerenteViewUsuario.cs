using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocesDePapelV1._1.Views
{
    public interface IGerenteViewUsuario
    {
        //propiedades
        string UsuarioId{ get; set; }
        string UsuarioNombre { get; set; }
        string UsuarioApellido { get; set; }
        string Contraseña { get; set; }
        string CuitUsuario { get; set; }
        string Baja { get; set; }
        string UsuarioIdRol { get; set; }
        string NombreEstado { get; set; }
        string NombreRol { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        BindingSource UsuarioBindingSource { get; }
        BindingSource EstadoBindingSource { get; }
        BindingSource RolBindingSource { get; }

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
        void SetEstadoListBindingSource(BindingSource estadoList);
        void SetRolListBindingSource(BindingSource rolList);
        void Show(); //mostrar formulario

        void SetDefaultEstado(string estadoId);
        void SetDefaultRol(string rolId);
        void LimpiarCampos();
    }
}
