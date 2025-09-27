using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Views;
using VocesDePapelV1._1.Servicios;
using VocesDePapelV1._1.Presenters.Common;

namespace VocesDePapelV1._1.Presenters
{
    public class ProductoPresenter
    {
        private IAdministradorViewProducto view;
        public ProductoPresenter(IAdministradorViewProducto view)
        {
            this.view = view;
            this.view.Show();
        }
    }
}
