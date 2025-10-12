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
        public event EventHandler EditarClienteEvent;
        public event EventHandler SearchClienteByCuitEvent;
        public event EventHandler ClearClienteEvent;
        public event EventHandler SearchVendedorByCuitEvent;
        public event EventHandler ClearVentaEvent;
        public Form FormInstance => this; // Devuelve la instancia actual del formulario

        // Propiedades del CLIENTE
        public string ClienteCuit
        {
            get { return TBCuilCuit.Text; } // Reemplaza con el nombre real de tu TextBox
            set { TBCuilCuit.Text = value; }
        }

        public string ClienteNombre
        {
            get { return TBNombreCliente.Text; } // Reemplaza con el nombre real de tu TextBox
            set { TBNombreCliente.Text = value; }
        }

        public string ClienteEmail
        {
            get { return TBEmail.Text; } 
            set { TBEmail.Text = value; }
        }

        public string ClienteTelefono
        {
            get { return TBTelefono.Text; } 
            set { TBTelefono.Text = value; }
        }

        // propiedades del VENDEDOR
        public string VendedorCuit
        {
            get { return TBCuitVendedor.Text; } 
            set { TBCuitVendedor.Text = value; }
        }

        public string VendedorNombre
        {
            get { return TBNombreApellidoVendedor.Text; } 
            set { TBNombreApellidoVendedor.Text = value; }
        }
        //propiedades del producto 

        // propiedad para el número de factura
        public string NumeroFactura
        {
            get { return TBNUmFactura.Text; } // Asumiendo que tienes un TextBox para esto
            set { TBNUmFactura.Text = value; }
        }
        private void AssociateAndRaiseViewEvents()
        {

            BAgregarCliente.Click += delegate { AddNewClienteEvent?.Invoke(this, EventArgs.Empty); };
            TBCuilCuit.TextChanged += delegate { SearchClienteByCuitEvent?.Invoke(this, EventArgs.Empty); };
            BLimpiarCliente.Click += delegate { ClearClienteEvent?.Invoke(this, EventArgs.Empty); };
            TBCuitVendedor.TextChanged += delegate { SearchVendedorByCuitEvent?.Invoke(this, EventArgs.Empty); };
            btn_limpiar_Venta.Click += delegate { ClearVentaEvent?.Invoke(this, EventArgs.Empty); };
        

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
        public object ProductosDataSource
        {
            get { return DGVProductos.DataSource; }
            set { DGVProductos.DataSource = value; }
        }
        public void LimpiarListaProductos()
        {
            DGVProductos.Rows.Clear();
            DGVProductos.DataSource = null;
        }
    }
}
