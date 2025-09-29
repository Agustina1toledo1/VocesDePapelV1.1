using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Views;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Servicios;
using System.Windows.Forms;

namespace VocesDePapelV1._1.Presenters
{
    public class GerentePresenter
    {
        private IGerenteView view;
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
            IGerenteReporteLibroMasVendidos backupView = GerenteViewReporteLibroMasVendidos.GetInstance((GerenteView)this.view); // muestra solo una instancia de la vista de usuario

            new ReporteLibroMasVendidosPresenter(backupView);
        }

        private void ShowReporteLibroStockView(object? sender, EventArgs e)
        {
            IGerenteReporteLibroStock backupView = GerenteViewReporteLibroStock.GetInstance((GerenteView)this.view); // muestra solo una instancia de la vista de usuario

            new ReporteLibroStockPresenter(backupView);
        }

        private void ShowReporteVentaView(object? sender, EventArgs e)
        {
            IGerenteViewReporteV backupView = GerenteViewReporteV.GetInstance((GerenteView)this.view); // muestra solo una instancia de la vista de usuario

            new ReporteVentaGerentePresenter(backupView);
        }

        private void ShowUsuariosView(object? sender, EventArgs e)
        {
            IGerenteViewUsuario usuarioView = GerenteViewUsuario.GetInstance((GerenteView)this.view); // muestra solo una instancia de la vista de usuario
            IUsuarioRepository repository = new UsuarioRepository(connectionString);
            IContraseniaHasher hasher = new pbkdf2ContraseniaHasher();
            new UsuarioPresenter(usuarioView, repository, hasher);
        }
        private void ShowBackupView(object? sender, EventArgs e)
        {
            IGerenteBackupView backupView = GerenteBackupView.GetInstance((GerenteView)this.view); // muestra solo una instancia de la vista de usuario
            
            new BackupPresenter(backupView);
        }


    }
}
