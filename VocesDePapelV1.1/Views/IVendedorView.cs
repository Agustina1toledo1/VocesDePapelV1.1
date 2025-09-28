using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocesDePapelV1._1.Views
{
    public interface IVendedorView
    {
        //Muestra las opciones del gerente
        event EventHandler ShowVentaView;
        event EventHandler ShowClienteView;
        event EventHandler ShowReporteVentaView;
        event EventHandler LogoutEvent;

        void Ocultar();        
        void Cerrar();
    }
}
