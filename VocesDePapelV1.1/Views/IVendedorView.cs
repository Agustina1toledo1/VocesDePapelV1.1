using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocesDePapelV1._1.Views
{
    public interface IVendedorView
    {
        //propiedad para el patron singleton
        Form FormInstance { get; }
        //Muestra las opciones del gerente
        event EventHandler ShowVentaView;
        event EventHandler ShowClienteView;
        event EventHandler ShowReporteVentaView;
        event EventHandler LogoutEvent;
        event EventHandler ShowComprobanteView;

        void Ocultar();        
        void Cerrar();
    }
}
