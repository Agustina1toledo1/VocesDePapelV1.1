using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocesDePapelV1._1.Views
{
    public interface IGerenteView
    {
        //Muestra las opciones del gerente
        event EventHandler ShowUsuarioView;
        event EventHandler ShowBackupView;
        event EventHandler ShowReporteVentaView;
        event EventHandler ShowReporteLibroView;
    }
}
