using VocesDePapelV1._1.Repositories;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Views;
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
                Form parentContainer = this.view.FormInstance;
                IVendedorCliente clienteView = VendedorViewCliente.GetInstance(parentContainer);

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
            // Obtener el contenedor padre (ya corregido en A)
           // Form parentContainer = this.view.FormInstance;

            // 2. Obtener la vista, PASANDO LA CONEXIÓN (CS0121)
            // Asumimos que GerenteViewReporteV.GetInstance acepta ahora la conexión
           // IGerenteViewReporteV backupView = GerenteViewReporteV.GetInstance(parentContainer, this.connectionString);

            // 3. Crear el Presenter, PASANDO LA CONEXIÓN (Missing Constructor)
            // Asumimos que ReporteVentaGerentePresenter acepta ahora la conexión
           //new ReporteVentaGerentePresenter(backupView, this.connectionString);

        }

        private void ShowVentaView(object? sender, EventArgs e)
        {
            string connStr = this.connectionString; // Asumiendo que VendedorPresenter tiene la conexión

            // Obtener el contenedor padre (asumiendo que this.view es VendedorView, el MDI parent)
            Form parentContainer = (Form)this.view;

             //  Pasar la cadena de conexión
            IVendedorVenta backupView = VentaView.GetInstance(parentContainer, connStr);

            // Crear el Presenter de Venta, pasando la conexión
            new VendedorVentaPresenter(backupView, connStr);
        }
    }
}
