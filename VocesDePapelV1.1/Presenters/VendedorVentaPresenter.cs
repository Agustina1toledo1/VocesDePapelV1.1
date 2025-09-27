using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Views;

namespace VocesDePapelV1._1.Presenters
{
    public class VendedorVentaPresenter
    {
        private IVendedorVenta view; //campo privado para la vista usando la interfaz

        public VendedorVentaPresenter(IVendedorVenta view)
        {
            this.view = view;
            //mostramos la vista
            this.view.Show();
        }
    }
}
