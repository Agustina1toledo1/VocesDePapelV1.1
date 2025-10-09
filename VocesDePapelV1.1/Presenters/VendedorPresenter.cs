using VocesDePapelV1._1.Repositories;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Views;


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
            this.view.LogoutEvent += LogoutEvent;

        }

        private void LogoutEvent(object? sender, EventArgs e)
        {
            //view.Ocultar(); // Oculta la vista actual
            //Program.IniciarAplicacion(); 
            view.Cerrar(); // Se cierra la vista actual después de que el login termine
        }

        private void ShowClienteView(object? sender, EventArgs e)
        {
            try
            {
                // Obtener la vista
                IVendedorCliente clienteView = VendedorViewCliente.GetInstance((VendedorView)this.view);

                // VERIFICAR conexión
                if (string.IsNullOrEmpty(this.connectionString))
                {
                    MessageBox.Show("Error: Cadena de conexión no configurada");
                    return;
                }

                // CREAR REPOSITORIO
                IClienteRepository clienteRepository = new ClienteRepository(this.connectionString);

                // VERIFICAR que el repositorio no sea null
                if (clienteRepository == null)
                {
                    MessageBox.Show("Error: No se pudo crear el repositorio de clientes");
                    return;
                }

                // Instanciar el Presenter
                new VendedorClientePresenter(clienteView, clienteRepository);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir vista de clientes: {ex.Message}");
            }
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
