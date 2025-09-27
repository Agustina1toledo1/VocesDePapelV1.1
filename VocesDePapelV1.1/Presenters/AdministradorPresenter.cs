using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Views;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Servicios;
using System.Windows.Forms;

namespace VocesDePapelV1._1.Presenters
{
    public class AdministradorPresenter
    {
        private IAdministradorView view;
        //un campo de solo lectura para la cadena de conexion
        private readonly string connectionString;

        public AdministradorPresenter(IAdministradorView view, string connectionString)
        {
            this.view = view;
            this.connectionString = connectionString;

            //suscribirse a los eventos de la vista
            this.view.ShowProductoView += ShowProductoView;

        }

        private void ShowProductoView(object? sender, EventArgs e)
        {
            IAdministradorViewProducto backupView = AdministradorViewProducto.GetInstance((AdministradorView)this.view); // muestra solo una instancia de la vista de usuario

            new ProductoPresenter(backupView);
        }
    }
}
