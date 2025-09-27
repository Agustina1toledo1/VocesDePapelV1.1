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
    public class VendedorPresenter
    {
        private IVendedorView view;
        //un campo de solo lectura para la cadena de conexion
        private readonly string connectionString;

        public VendedorPresenter(IVendedorView view, string connectionString)
        {
            this.view = view;
            this.connectionString = connectionString;

            //suscribirse a los eventos de la vista
            this.view.ShowVentaView += ShowVentaView;
            this.view.ShowClienteView += ShowClienteView;
            this.view.ShowReporteVentaView += ShowReporteVentaView;

        }

        private void ShowClienteView(object? sender, EventArgs e)
        {
            IVendedorCliente backupView = VendedorViewCliente.GetInstance((VendedorView)this.view); // muestra solo una instancia de la vista de usuario
            new VendedorClientePresenter(backupView);
        }

        private void ShowReporteVentaView(object? sender, EventArgs e)
        {
            IGerenteViewReporteV backupView = GerenteViewReporteV.GetInstance((VendedorView)this.view); // muestra solo una instancia de la vista de usuario
            new ReporteVentaGerentePresenter(backupView);
        }

        private void ShowVentaView(object? sender, EventArgs e)
        {
            IVendedorVenta backupView = VentaView.GetInstance((VendedorView)this.view); // muestra solo una instancia de la vista de usuario

            new VendedorVentaPresenter(backupView);
        }
    }
}
