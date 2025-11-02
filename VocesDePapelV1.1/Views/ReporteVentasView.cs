using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VocesDePapelV1._1.Models;

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
        // Propiedades para saber el tipo de usuario
        public bool EsModoVendedor { get; set; }
        public int IdVendedorAutomatico { get; set; }

        // Propiedades  para filtros
        public string TxtVendedorAuto
        {
            get => txtVendedorAuto?.Text ?? string.Empty;
            set
            {
                if (txtVendedorAuto != null)
                    txtVendedorAuto.Text = value;
            }
        }
        public bool CmbTipoReporteEnabled
        {
            get => cmbTipoReporte.Enabled;
            set => cmbTipoReporte.Enabled = value;
        }
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
      
        public int? IdVendedorSeleccionado
        {
            get => cmbVendedores.SelectedValue as int?;
            set => cmbVendedores.SelectedValue = value;
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
        public bool FiltroVendedorVisible
        {
            get
            {
                // Verificar si los controles del filtro están visibles
                return lblFiltroAdicional.Visible &&
                       (cmbVendedores != null ? cmbVendedores.Visible : txtFiltroAdicional.Visible);
            }
            set
            {
                // Mostrar/ocultar el label del filtro
                lblFiltroAdicional.Visible = value;

                if (EsModoVendedor)
                {
                    // MODO VENDEDOR: Usar TextBox o Label fijo
                    if (txtVendedorAuto != null)
                    {
                        txtVendedorAuto.Visible = value;
                    }
                    if (cmbVendedores != null)
                    {
                        cmbVendedores.Visible = false;
                    }
                    lblFiltroAdicional.Text = "Vendedor:";
                }
                else
                {
                    // MODO GERENTE: Usar ComboBox para selección
                    if (cmbVendedores != null)
                    {
                        cmbVendedores.Visible = value;
                    }
                    if (txtVendedorAuto != null)
                    {
                        txtVendedorAuto.Visible = false;
                    }
                    lblFiltroAdicional.Text = "Seleccionar Vendedor:";
                }

                // Si el filtro está oculto, también ocultar el textbox normal
                if (!value && txtFiltroAdicional != null)
                {
                    txtFiltroAdicional.Visible = false;
                }
            }
        }

        public List<UsuarioModel> ListaVendedores
        {
            get
            {
                if (cmbVendedores != null && cmbVendedores.DataSource != null)
                    return cmbVendedores.DataSource as List<UsuarioModel>;
                return new List<UsuarioModel>();
            }
            set
            {
                if (cmbVendedores != null)
                {
                    cmbVendedores.DataSource = value;
                    cmbVendedores.DisplayMember = "NombreCompleto"; // Usar la propiedad que creamos
                    cmbVendedores.ValueMember = "IdUsuario";
                    cmbVendedores.SelectedIndex = -1; // Sin selección por defecto
                }
            }
        }
    }
}
