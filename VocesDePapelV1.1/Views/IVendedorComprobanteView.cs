using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocesDePapelV1._1.Views
{
    public interface IVendedorComprobanteView
    {
        //propiedades
        string SearchNumeroComprobante { get; set; }  
        string Message { get; set; }
        bool IsSuccessful { get; set; }

        //eventos
        event EventHandler SearchComprobanteEvent;
        event EventHandler ShowComprobanteEvent;

        //metodos
        void SetComprobanteFiltradoListBindingSource(object comprobanteList); //metodo para enlazar la lista de comprobantes
        void Show(); //mostrar formulario
    }
}
