using System.ComponentModel;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Views
{
    public partial class VentaView : Form, IVentaView
    {
        private readonly string connectionString;
        private BindingList<VentaDetalleModel> detalles;
        private BindingSource ventaListBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.GroupBox groupBoxProductos;
        private System.Windows.Forms.Button btnSeleccionarProducto;
        private System.Windows.Forms.ComboBox comboBoxTipoBusqueda;
        private System.Windows.Forms.Label labelTipoBusqueda;

        // Campos privados para las nuevas propiedades
        private string productoSeleccionadoNombre;
        private string productoSeleccionadoCategoria;
        private decimal productoSeleccionadoPrecio;
        private int productoSeleccionadoStock;
        public VentaView(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.detalles = new BindingList<VentaDetalleModel>();
            this.ventaListBindingSource = new BindingSource();
            InitializeDataGridView();
            AssociateAndRaiseViewEvents();
        }

        private void InitializeDataGridView()
        {
            // Configurar columnas del DataGridView
            dataGridViewDetalles.Columns.Add("Id_libro", "ID Libro");
            dataGridViewDetalles.Columns.Add("Titulo_libro", "Producto");
            dataGridViewDetalles.Columns.Add("Cantidad", "Cantidad");
            dataGridViewDetalles.Columns.Add("PrecioUnitario", "Precio Unitario");
            dataGridViewDetalles.Columns.Add("Subtotal", "Subtotal");

            // Configurar propiedades
            dataGridViewDetalles.Columns["Id_libro"].ReadOnly = true;
            dataGridViewDetalles.Columns["Titulo_libro"].ReadOnly = true;
            dataGridViewDetalles.Columns["PrecioUnitario"].DefaultCellStyle.Format = "C2";
            dataGridViewDetalles.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
        }
        //singleton patron (abre una sola instancia del formulario) 
        private static VentaView instance;

        public event EventHandler AddNewClienteEvent;
        public event EventHandler EditarClienteEvent;
        public event EventHandler SearchClienteByCuitEvent;
        public event EventHandler ClearClienteEvent;
        public event EventHandler SearchVendedorByCuitEvent;
        // eventos para las acciones de la venta
        public event EventHandler FinalizarVentaEvent;
        public event EventHandler CancelarVentaEvent;
        public event EventHandler AgregarProductoEvent;
        public event EventHandler BuscarProductoEvent;
        public event EventHandler EliminarProductoEvent;
        public event EventHandler SearchEvent;
        public event EventHandler VerDetallesEvent;
        public event EventHandler LimpiarDetallesEvent;
        public event EventHandler AnularVentaEvent;
        public event EventHandler CantidadCambiadaEvent;
        public event EventHandler PrecioCambiadoEvent;
        // Propiedades del formulario
        public Form FormInstance => this; // Devuelve la instancia actual del formulario
        // Propiedades del cliente
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
        // Propiedades de productos
        public string ProductoBusqueda
        {
            get { return TBSearch.Text; }
            set { TBSearch.Text = value; }
        }

        public int ProductoSeleccionadoId { get; set; }
        public int ProductoCantidad {
            get{ return (int)NUDCantidadProducto.Value; }
            set { NUDCantidadProducto.Value = value;}
        }
        public decimal ProductoPrecio { 
            get{ return decimal.TryParse(TBPrecio.Text, out decimal result) ? result : 0;
            }
            set{ TBPrecio.Text = value.ToString("F2"); }
        }
        public string ProductoSeleccionadoNombre
        {
            get { return TBNomProducto.Text; }//productoSeleccionadoNombre
            set { TBNomProducto.Text = value; }
        }

        public string ProductoSeleccionadoCategoria
        {
            get { return productoSeleccionadoCategoria; }
            set { productoSeleccionadoCategoria = value; }
        }

        public string ProductoSeleccionadoPrecio
        {
            get { return TBPrecio.Text; }
            set { TBPrecio.Text = value; }
        }

        public string ProductoSeleccionadoStock
        {
            get { return TBSTock.Text; }
            set { TBSTock.Text = value; }
        }
        public decimal ProductoSeleccionadoSubtotal
        {
            get { return decimal.TryParse(TBSubTotal.Text, out decimal result) ? result : 0;
            }
            set { TBSubTotal.Text = value.ToString("F2"); } // Actualizar el control de la vista      
        }

        // Propiedades de venta
        public string NumeroFactura
        {
            get { return TBNUmFactura.Text; } // Asumiendo que tienes un TextBox para esto
            set { TBNUmFactura.Text = value; }
        }
        public DateTime FechaVenta { get; set; }

        public int IdCliente { get; set; }

        public decimal TotalVenta
        {
            get {
                decimal total = detalles.Sum(d => d.Subtotal);
                TBPrecioTotal.Text = total.ToString("F2");
                return total;
            }
            set { TBPrecioTotal.Text = value.ToString("F2"); }
        }
        // Propiedades de binding
        public BindingList<VentaDetalleModel> Detalles => detalles;

        public BindingSource VentaListBindingSource => ventaListBindingSource;

        public string SearchValue => TBSearch.Text;
        private void dataGridViewProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SeleccionarProductoDesdeGrid();
            }
        }

        private void SeleccionarProductoDesdeGrid()
        {
            if (dataGridViewProductos.CurrentRow != null)
            {
                var producto = (ProductoModel)dataGridViewProductos.CurrentRow.DataBoundItem;

                // Autocompletar campos de producto
                ProductoSeleccionadoId = producto.Id_libro;
                TBNomProducto.Text = producto.Titulo;
                TBPrecio.Text = producto.Precio.ToString("F2");
                TBSTock.Text = producto.Stock.ToString();

                ProductoSeleccionadoNombre = producto.Titulo;
                ProductoSeleccionadoPrecio = producto.Precio.ToString();
                ProductoSeleccionadoStock = producto.Stock.ToString();
                ProductoSeleccionadoCategoria= producto.Nombre_categoria;
                // Ocultar grid de productos
                groupBoxProductos.Visible = false;
            }
        }
        private void AssociateAndRaiseViewEvents()
        {

            BAgregarCliente.Click += delegate { AddNewClienteEvent?.Invoke(this, EventArgs.Empty); };
            TBCuilCuit.TextChanged += delegate { SearchClienteByCuitEvent?.Invoke(this, EventArgs.Empty); };
            BLimpiarCliente.Click += delegate { ClearClienteEvent?.Invoke(this, EventArgs.Empty); };
            TBCuitVendedor.TextChanged += delegate { SearchVendedorByCuitEvent?.Invoke(this, EventArgs.Empty); };
            // btn_limpiar_Venta.Click += delegate { ClearVentaEvent?.Invoke(this, EventArgs.Empty); };
            TBSearch.TextChanged += delegate { BuscarProductoEvent?.Invoke(this, EventArgs.Empty); };
            BtnAgregarDetalle.Click += delegate { AgregarProductoEvent?.Invoke(this, EventArgs.Empty); };
            BtnEliminarDetalle.Click += delegate { EliminarProductoEvent?.Invoke(this, EventArgs.Empty); };
            BtnLimpiarDetalles.Click += delegate { LimpiarDetallesEvent?.Invoke(this, EventArgs.Empty); };
            NUDCantidadProducto.ValueChanged += (s, e) => { System.Diagnostics.Debug.WriteLine($"Cantidad cambiada: {NUDCantidadProducto.Value}");
            CantidadCambiadaEvent?.Invoke(s, e);};
            TBPrecio.TextChanged += (s, e) => { System.Diagnostics.Debug.WriteLine($"Precio cambiado: {TBPrecio.Text}");
            PrecioCambiadoEvent?.Invoke(s, e); };
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
        public string TipoBusqueda
        {
            get { return comboBoxTipoBusqueda.SelectedItem?.ToString() ?? "Título"; }
            set { comboBoxTipoBusqueda.SelectedItem = value; }
        }
        public void AgregarDetalle(VentaDetalleModel detalle)
        {
            if (detalle == null) return;

            // Verificar si ya existe
            var detalleExistente = detalles.FirstOrDefault(d => d.Id_libro == detalle.Id_libro);
            if (detalleExistente != null)
            {
                detalleExistente.Cantidad += detalle.Cantidad;
            }
            else
            {
                detalles.Add(detalle);
            }

            ActualizarDataGridView();
            CalcularTotal();
        }

        public void EliminarDetalle(int index)
        {
            if (index >= 0 && index < detalles.Count)
            {
                detalles.RemoveAt(index);
                ActualizarDataGridView();
                CalcularTotal();
            }
        }
        public void EliminarDetalle() // Sobrecarga para compatibilidad
        {
            if (dataGridViewDetalles.SelectedRows.Count > 0)
            {
                int index = dataGridViewDetalles.SelectedRows[0].Index;
                EliminarDetalle(index);
            }
        }

        public void LimpiarDetalles()
        {
            detalles.Clear();
            dataGridViewDetalles.Rows.Clear();
            CalcularTotal();
        }

        public void MostrarDetallesVenta(IEnumerable<VentaDetalleModel> detalles)
        {
            this.detalles.Clear();
            foreach (var detalle in detalles)
            {
                this.detalles.Add(detalle);
            }
            ActualizarDataGridView();
            CalcularTotal();
        }
        private void BBuscarProducto_Click(object sender, EventArgs e)
        {
            // Verificar que haya texto de búsqueda
            if (!string.IsNullOrWhiteSpace(ProductoBusqueda))
            {
                BuscarProductoEvent?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MostrarMensaje("Ingrese un término de búsqueda", false);
            }
        }
        // Método auxiliar para calcular el total
        private void ActualizarDataGridView()
        {
            dataGridViewDetalles.Rows.Clear();
            foreach (var detalle in detalles)
            {
                int rowIndex = dataGridViewDetalles.Rows.Add();
                DataGridViewRow row = dataGridViewDetalles.Rows[rowIndex];
                row.Cells["Id_libro"].Value = detalle.Id_libro;
               // row.Cells["Titulo_libro"].Value = detalle.Titulo_libro;
                row.Cells["Cantidad"].Value = detalle.Cantidad;
                row.Cells["PrecioUnitario"].Value = detalle.Precio_unitario;
                row.Cells["Subtotal"].Value = detalle.Subtotal;
            }
        }
        public void MostrarProductosEncontrados(IEnumerable<ProductoModel> productos)
        {
            using (var searchForm = new ProductoSearchView(productos))
            {
                // Suscribirse al evento de selección
                searchForm.ProductoSeleccionadoEvent += (sender, e) =>
                {
                    var producto = e.Producto;
                    AsignarProductoSeleccionado(producto);
                };

                if (searchForm.ShowDialog() == DialogResult.OK && searchForm.ProductoSeleccionado != null)
                {
                    var producto = searchForm.ProductoSeleccionado;

                    AsignarProductoSeleccionado(producto);
                    MostrarMensaje($"Producto seleccionado: {producto.Titulo}", true);
                }
            }
        }
        private void AsignarProductoSeleccionado(ProductoModel producto)
        {
            // Actualizar propiedades de la interfaz
            ProductoSeleccionadoId = producto.Id_libro;
            ProductoSeleccionadoNombre = producto.Titulo;
            ProductoSeleccionadoPrecio = producto.Precio.ToString();
            ProductoSeleccionadoStock = producto.Stock.ToString();

         /*   // Si tu ProductoModel tiene categoría
            if (producto.GetType().GetProperty("Categoria") != null)
            {
                ProductoSeleccionadoCategoria = producto.Id_categoria;
            }
            else
            {
                ProductoSeleccionadoCategoria = "Sin categoría"; // Valor por defecto
            }*/

            // Actualizar controles de la UI
            TBNomProducto.Text = producto.Titulo;
            TBPrecio.Text = producto.Precio.ToString("F2");
            TBSTock.Text = producto.Stock.ToString();

            // También actualizar las propiedades existentes
            ProductoPrecio = producto.Precio;
        }

       
        private void CalcularTotal()
        {
            decimal total = detalles.Sum(d => d.Subtotal);
            TotalVenta = total;
        }
        // Método para obtener los detalles actuales del DataGridView
        public List<VentaDetalleModel> ObtenerDetallesActuales()
        {
            var detalles = new List<VentaDetalleModel>();

            foreach (DataGridViewRow row in dataGridViewDetalles.Rows)
            {
                if (!row.IsNewRow && row.Cells["Id_libro"].Value != null)
                {
                    var detalle = new VentaDetalleModel
                    {
                        Id_libro = Convert.ToInt32(row.Cells["Id_libro"].Value),
                        //Titulo_libro = row.Cells["Titulo_libro"].Value?.ToString() ?? "",
                        Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                        Precio_unitario = Convert.ToDecimal(row.Cells["Precio_unitario"].Value),
                        //Subtotal = Convert.ToDecimal(row.Cells["Subtotal"].Value)
                    };
                    detalles.Add(detalle);
                }
            }

            return detalles;
        }
        public void MostrarMensaje(string mensaje, bool esExitoso)
        {
            MessageBox.Show(mensaje,
                esExitoso ? "Éxito" : "Error",
                MessageBoxButtons.OK,
                esExitoso ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        }

        // Evento para recalcular cuando cambia la cantidad o precio (opcional)
        private void dataGridViewDetalles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 &&
                (dataGridViewDetalles.Columns[e.ColumnIndex].Name == "Cantidad" ||
                 dataGridViewDetalles.Columns[e.ColumnIndex].Name == "PrecioUnitario"))
            {
                RecalcularFila(e.RowIndex);
                CalcularTotal();
            }
        }

        private void RecalcularFila(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dataGridViewDetalles.Rows.Count)
            {
                DataGridViewRow row = dataGridViewDetalles.Rows[rowIndex];

                if (row.Cells["Cantidad"].Value != null && row.Cells["PrecioUnitario"].Value != null)
                {
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    decimal precio = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value);
                    decimal subtotal = cantidad * precio;

                    row.Cells["Subtotal"].Value = subtotal;
                }
            }
        }
        void IVentaView.Show()
        {
            base.Show();
        }

    }
}
