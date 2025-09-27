using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Views;

namespace VocesDePapelV1._1.Presenters
{
    public class VendedorClientePresenter
    {
        private IVendedorCliente view; //campo privado para la vista usando la interfaz

        public VendedorClientePresenter(IVendedorCliente view)
        {
            this.view = view;
            //mostramos la vista
            this.view.Show();
        }
    }
}
