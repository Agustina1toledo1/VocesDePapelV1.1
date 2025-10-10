namespace VocesDePapelV1._1.Views
{
    public partial class VentaView : Form, IVendedorVenta
    {
        private readonly string connectionString;
        public VentaView(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            AssociateAndRaiseViewEvents();
        }
        //singleton patron (abre una sola instancia del formulario) 
        private static VentaView instance;

        public event EventHandler AddNewClienteEvent;
        public Form FormInstance => this; // Devuelve la instancia actual del formulario
        private void AssociateAndRaiseViewEvents()
        {

            BAgregarCliente.Click += delegate { AddNewClienteEvent?.Invoke(this, EventArgs.Empty); };
        }

        public static VentaView GetInstance(Form parentConteiner, string connectionString)
        {
            if (instance == null || instance.IsDisposed) //si es nulo o esta desechado
            {
                instance = new VentaView(connectionString); // PASAR LA CONEXIÓN
                instance.MdiParent = parentConteiner;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
                //instance.AssociateAndRaiseViewEvents();
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)//si esta minimizado, restaurar
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();//si ya existe, traer al frente

            }
            return instance;
        }
        void IVendedorVenta.Show()
        {
            base.Show();
        }

    }
}
