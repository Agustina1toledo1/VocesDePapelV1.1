using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Views;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Presenters;
using VocesDePapelV1._1.Servicios;
using System.Windows.Forms;
using VocesDePapelV1._1.Repositories;

namespace VocesDePapelV1._1.Presenters
{
    public class GerentePresenter
    {
        private IGerenteView view;
        private bool esModoVendedor;
        private int? idUsuario;
        private UsuarioPresenter usuarioPresenter;
        private BackupPresenter backupPresenter;
        private ReporteProductoPresenter reporteProductoPresenter;
        private ReporteLibroMasVendidosPresenter reporteLibroMasVendidosPresenter;

        //un campo de solo lectura para la cadena de conexion
        private readonly string connectionString;

        public GerentePresenter(IGerenteView view, string connectionString)
        {
            this.view = view;
            this.connectionString = connectionString;

            //suscribirse a los eventos de la vista
            this.view.ShowUsuarioView += ShowUsuariosView;
            this.view.ShowBackupView += ShowBackupView;
            this.view.ShowReporteVentaView += ShowReporteVentaView;
            this.view.ShowReporteLibroStockView += ShowReporteLibroStockView;
            this.view.ShowReporteLibroMasVendidosView += ShowReporteLibroMasVendidosView;
            this.view.LogoutEvent += LogoutEvent;
        }

        private void LogoutEvent(object? sender, EventArgs e)
        {
            //view.Ocultar(); 
            //Program.IniciarAplicacion(); 
            view.Cerrar();
        }

        private void ShowReporteLibroMasVendidosView(object? sender, EventArgs e)
        {
            IGerenteReporteLibroMasVendidos view = GerenteViewReporteLibroMasVendidos.GetInstance((GerenteView)this.view); // muestra solo una instancia de la vista de usuario
           
            if (reporteLibroMasVendidosPresenter == null)
            {
                IProductoRepository repository = new ProductoRepository(connectionString);
                reporteLibroMasVendidosPresenter = new ReporteLibroMasVendidosPresenter(view, repository);
            }
           
        }

        private void ShowReporteLibroStockView(object? sender, EventArgs e)
        {

            IGerenteReporteLibroStock view = GerenteViewReporteLibroStock.GetInstance((GerenteView)this.view); // muestra solo una instancia de la vista de usuario
            
            if (reporteProductoPresenter == null)
            {
                IProductoRepository repository = new ProductoRepository(connectionString);
                
                reporteProductoPresenter = new ReporteProductoPresenter(view, repository);
            }
        }

        private void ShowReporteVentaView(object? sender, EventArgs e)
        {
            
            IGerenteViewReporteVentas reporteView = ReporteVentasView.GetInstance((GerenteView)this.view);
            IVentaReporteRepository repository = new VentaReporteRepository(connectionString);
            new ReporteVentasPresenter(reporteView, repository, false, null);
        }

        private void ShowUsuariosView(object? sender, EventArgs e)
        {
            IGerenteViewUsuario usuarioView = GerenteViewUsuario.GetInstance((GerenteView)this.view); // muestra solo una instancia de la vista de usuario
            if(usuarioPresenter == null)
            {

                IUsuarioRepository repository = new UsuarioRepository(connectionString);
                IContraseniaHasher hasher = new pbkdf2ContraseniaHasher();
                usuarioPresenter = new UsuarioPresenter(usuarioView, repository, hasher);
            }
        }
        private void ShowBackupView(object? sender, EventArgs e)
        {

            IGerenteBackupView backupView = GerenteBackupView.GetInstance((GerenteView)this.view); // muestra solo una instancia de la vista de usuario
            if (backupPresenter == null)
            {
                backupPresenter = new BackupPresenter(backupView, connectionString);
            }

        }


    }
}
