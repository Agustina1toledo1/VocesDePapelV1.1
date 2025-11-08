using VocesDePapelV1._1.Repositories;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Views;
using System.Windows.Forms;


namespace VocesDePapelV1._1.Presenters
{
    public class VendedorPresenter
    {
        private IVendedorView view;
        private bool esModoVendedor;
        private int? idUsuario;

        //un campo de solo lectura para la cadena de conexion
        private readonly string connectionString;
        private VendedorVentaPresenter2 ventaPresenter; //para no repetir instancias de venta


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
            Form parentContainer = this.view.FormInstance;

            IGerenteViewReporteVentas reporteView = ReporteVentasView.GetInstance(parentContainer);
            IVentaReporteRepository repository = new VentaReporteRepository(connectionString);
            int idVendedor = 0;
            string cuitVendedor = string.Empty;

            using (var popup = new Cuit())
            {
                if (popup.ShowDialog() == DialogResult.OK)
                {
                    cuitVendedor = popup.CuitIngresado;
                }
                else
                {
                    // El usuario canceló o cerró el pop-up
                    return;
                }
            }

            // --- 2. Buscar el ID usando el CUIT ---
            try
            {
                // Usar el Repositorio para buscar el ID real
                idVendedor = repository.GetVendedoresActivos()
                    .FirstOrDefault(v => v.Cuit_usuario == cuitVendedor)?.Id_usuario ?? 0;
            }
            catch
            {
                // Manejo de error si el CUIT no existe
                MessageBox.Show("CUIT no encontrado o no es un vendedor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- 3. Crear el Presentador con el ID Obtenido ---
            if (idVendedor > 0)
            {
                // Se abre el reporte en modo vendedor con el ID encontrado
                new ReporteVentasPresenter(reporteView, repository, true, idVendedor);
            }
            else
            {
                MessageBox.Show("No se pudo obtener el ID del vendedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        

        private void ShowVentaView(object? sender, EventArgs e)
        {
            IVentaView2 ventaView = VentaView2.GetInstance((VendedorView)this.view);

            if (ventaPresenter == null)
            {
                IProductoSearchView2 productoSearchView = new ProductoSearchView2();
                IClienteRepository clienteRepository = new ClienteRepository(this.connectionString);
                IVentaCabeceraRepository2 ventaCabeceraRepository = new VentaCabeceraRepository2(this.connectionString);
                IVentaDetalleRepository2 ventaDetalleRepository = new VentaDetalleRepository2(this.connectionString);
                IUsuarioRepository usuarioRepository = new UsuarioRepository(this.connectionString);
                IProductoRepository productoRepository = new ProductoRepository(this.connectionString);

                ventaPresenter = new VendedorVentaPresenter2(
                    ventaView,
                    ventaCabeceraRepository,
                    ventaDetalleRepository,
                    clienteRepository,
                    productoRepository,
                    usuarioRepository
                );
            }

        }
    }
}
