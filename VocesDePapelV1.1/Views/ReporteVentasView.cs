using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocesDePapelV1._1.Views
{
    public partial class ReporteVentasView : Form, IGerenteViewReporteVentas
    {
        public ReporteVentasView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            
            btnBuscar.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };//  Evento Buscar
            
            btnGenerarPDF.Click += delegate { GenerateReportEvent?.Invoke(this, EventArgs.Empty); };//Evento Generar PDF
                       
            btnLimpiar.Click += delegate { LimpiarFiltrosEvent?.Invoke(this, EventArgs.Empty); };//Evento Limpiar

            // Enter en campos de texto
            txtFiltroAdicional.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
        }

        // para la interfaz
        public string FechaInicio
        {
            get => dtpFechaInicio.Value.ToString("yyyy-MM-dd");
            set
            {
                if (DateTime.TryParse(value, out DateTime fecha))
                    dtpFechaInicio.Value = fecha;
            }
        }

        public string FechaFin
        {
            get => dtpFechaFin.Value.ToString("yyyy-MM-dd");
            set
            {
                if (DateTime.TryParse(value, out DateTime fecha))
                    dtpFechaFin.Value = fecha;
            }
        }

        public string TipoReporte
        {
            get => cmbTipoReporte.SelectedItem?.ToString() ?? "PorFecha";
            set => cmbTipoReporte.SelectedItem = value;
        }

        public string FiltroAdicional
        {
            get => txtFiltroAdicional.Text;
            set => txtFiltroAdicional.Text = value;
        }

        public bool IncluirDetalles
        {
            get => chkIncluirDetalles.Checked;
            set => chkIncluirDetalles.Checked = value;
        }

        // PROPIEDADES para resultados
        public string TotalVentasPeriodo
        {
            get => lblTotalVentas.Text;
            set => lblTotalVentas.Text = value;
        }

        public string CantidadVentasPeriodo {
            get => lblCantidadVentas.Text;
            set => lblCantidadVentas.Text = value;
        }

        public string PromedioVenta
        {
            get => lblPromedioVenta.Text;
            set => lblPromedioVenta.Text = value;
        }
        public string CantidadVentas
        {
            get => lblCantidadVentas.Text;
            set => lblCantidadVentas.Text = value;
        }

        public string TotalVentas
        {
            get => lblTotalVentas.Text;
            set => lblTotalVentas.Text = value;
        }
        public string Message
        {
            get => lblMensaje.Text;
            set
            {
                lblMensaje.Text = value;
                lblMensaje.Visible = !string.IsNullOrEmpty(value);
            }
        }

        public bool IsSuccessful { get; set; }

        // EVENTOS 
        public event EventHandler SearchEvent;
        public event EventHandler GenerateReportEvent;
        public event EventHandler ExportExcelEvent;
        public event EventHandler LimpiarFiltrosEvent;
        

        //MÉTODOS 
        public void SetVentasListBindingSource(BindingSource ventasList)
        {
            dgvVentas.DataSource = ventasList;
        }

        //MÉTODO Singleton (patrón para una sola instancia)
        private static ReporteVentasView instance;
        public static ReporteVentasView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ReporteVentasView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
    }
}
