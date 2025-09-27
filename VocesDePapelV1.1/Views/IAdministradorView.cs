using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocesDePapelV1._1.Views
{
    public interface IAdministradorView
    {
        event EventHandler ShowProductoView;
        event EventHandler ShowReporteLibroStockView;
        event EventHandler ShowReporteLibroMasVendidosView;
        event EventHandler ShowAutoresView;
        event EventHandler ShowCategoriasView;
    }
}
