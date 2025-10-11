using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocesDePapelV1._1.Views
{
    public interface IVendedorCliente
    {
        //propiedad para el patron singleton
        Form FormInstance { get; }
        //propiedades para enlazar los datos de los controles de la vista
        string ClienteId { get; set; }
        string NombreRazonSocial { get; set; }
        string CuitCuil { get; set; }
        string Telefono { get; set; }
        string Email { get; set; }
        string SearchValue { get; }

        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Eventos que la vista expone al Presenter
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Metodos
        //enlace a la lista de usuarios
        void SetClienteListBindingSource(BindingSource clienteList);
        void Show();  //mostrar formulario
    }
}
