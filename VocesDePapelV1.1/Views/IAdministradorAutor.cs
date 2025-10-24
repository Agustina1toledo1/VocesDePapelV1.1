using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocesDePapelV1._1.Views
{
    public interface IAdministradorAutor
    {
        //propiedade
        string AutorId { get; set; }
        string AliasAutor { get; set; }
        string Estado_id { get; set; }
        string NombreEstado { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Eventos
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Metodos
        //enlace a la lista de autores
        void SetAutorListBindingSource(BindingSource autorList);
        void SetEstadoListBindingSource(BindingSource estadoList);

        void Show();
    }
}
