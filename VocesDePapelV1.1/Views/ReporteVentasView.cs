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


            // Configurar ComboBox de tipo reporte
            cmbTipoReporte.Items.Clear();
            cmbTipoReporte.Items.AddRange(new string[] {
            "Por Fecha",
            "Por Vendedor",
            "Por Cliente",  // Nuevo tipo
            
        });
            cmbTipoReporte.SelectedIndex = 0;
        }

        private void AssociateAndRaiseViewEvents()
        {

            btnBuscar.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };//  Evento Buscar

            btnGenerarPDF.Click += delegate { GenerateReportEvent?.Invoke(this, EventArgs.Empty); };//Evento Generar PDF

            btnLimpiar.Click += delegate { LimpiarFiltrosEvent?.Invoke(this, EventArgs.Empty); };//Evento Limpiar
            cmbTipoReporte.SelectedIndexChanged += cmbTipoReporte_SelectedIndexChanged;

        }
        // Propiedades para saber el tipo de usuario
        public bool EsModoVendedor
        {

            get { return !cmbVendedor.Visible && txtVendedorAuto.Visible; }
            set
            {
                if (value)
                {
                    // Modo vendedor: mostrar TextBox, ocultar ComboBox
                    cmbVendedor.Visible = false;
                    txtVendedorAuto.Visible = true;
                    lblVendedor.Text = "Vendedor:";
                }
                else
                {
                    // Modo gerente: mostrar ComboBox, ocultar TextBox
                    cmbVendedor.Visible = true;
                    txtVendedorAuto.Visible = false;
                    lblVendedor.Text = "Seleccionar Vendedor:";
                }
            }
        }


        // Propiedades  para filtros
        public bool CmbTipoReporteEnabled
        {
            get => cmbTipoReporte.Enabled;
            set => cmbTipoReporte.Enabled = value;
        }
        public DateTime FechaInicio
        {
            get => dtpFechaInicio.Value.Date; // Devuelve el DateTime con hora 00:00:00
            set
            {
                if (DateTime.TryParse(value.ToString(), out DateTime fecha))
                    dtpFechaInicio.Value = fecha;
            }
        }
        public DateTime FechaFin
        {
            get => dtpFechaFin.Value.Date; // Devuelve el DateTime con hora 00:00:00
            set
            {
                if (DateTime.TryParse(value.ToString(), out DateTime fecha))
                    dtpFechaFin.Value = fecha;
            }
        }
        public string TipoReporte
        {
            get => cmbTipoReporte.SelectedItem?.ToString() ?? "Por Fecha";
            set => cmbTipoReporte.SelectedItem = value;
        }
        public bool IncluirDetalles
        {
            get => chkIncluirDetalles.Checked;
            set => chkIncluirDetalles.Checked = value;
        }
        public string ValorBusqueda
        {
            get
            {
                if (cmbBusqueda.SelectedValue != null)
                    return cmbBusqueda.SelectedValue.ToString();
                return cmbBusqueda.Text;
            }
        }

        public string TextoBusqueda
        {
            set
            {
                if (cmbBusqueda != null)
                    cmbBusqueda.Text = value;
            }
        }
        public bool ComboBusquedaHabilitado
        {
            set
            {
                if (cmbBusqueda != null)
                    cmbBusqueda.Enabled = value;
            }
        }
        public string EtiquetaBusqueda
        {
            set
            {
                if (lblBusqueda != null)
                    lblBusqueda.Text = value;
            }
        }
        // PROPIEDADES para resultados
        public string TotalVentasPeriodo
        {
            get => lblTotalVentas.Text;
            set => lblTotalVentas.Text = $"Total Ventas: {value}";
        }
        public string CantidadVentasPeriodo
        {
            get => lblCantidadVentas.Text;
            set => lblCantidadVentas.Text = $"Cantidad Ventas: {value}";
        }
        public string PromedioVenta
        {
            get => lblPromedioVenta.Text;
            set => lblPromedioVenta.Text = $"Promedio Venta: {value}";
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
        public List<UsuarioModel> ListaVendedores
        {
            set
            {
                cmbVendedor.DataSource = value;
                cmbVendedor.DisplayMember = "NombreCompleto";
                cmbVendedor.ValueMember = "Id_usuario";
            }
        }
        //
        public int? IdVendedorSeleccionado
        {
            get
            {
                return cmbVendedor.SelectedValue as int?;
            }
        }
        public string NombreVendedorSeleccionado
        {
            get => cmbVendedor.Text;
            set => cmbVendedor.Text = value;
        }
        public List<ClienteModel> ListaClientes
        {
            set
            {
                cmbBusqueda.DataSource = value;
                cmbBusqueda.DisplayMember = "NombreRazonSocial";
                cmbBusqueda.ValueMember = "Cuit"; // O "Id_cliente" según tu modelo
            }
        }
        public bool ComboVendedorHabilitado
        {
            set
            {
                cmbVendedor.Enabled = value;
                cmbTipoReporte.Enabled = value;
            }
        }
        public string TextoVendedor
        {
            set
            {
                cmbVendedor.Text = value;
            }
        }
        public int VendedorSeleccionadoId
        {
            set
            {
                cmbVendedor.SelectedValue = value;
            }
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
        public event EventHandler LimpiarFiltrosEvent;
        public event EventHandler TipoReporteChangedEvent;


        //MÉTODOS 
        public void SetVentasListBindingSource(BindingSource ventasList)
        {
            dgvVentas.DataSource = ventasList;
        }
        private void cmbTipoReporte_SelectedIndexChanged(object? sender, EventArgs e)
        {           
            TipoReporteChangedEvent?.Invoke(this, EventArgs.Empty);
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
        /*public bool FiltroVendedorVisible
        {
            get
            {
                // Verificar si los controles del filtro están visibles
                return lblFiltroAdicional.Visible &&
                       (cmbVendedor != null ? cmbVendedor.Visible );
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
                    if (cmbVendedor != null)
                    {
                        cmbVendedor.Visible = false;
                    }
                    lblFiltroAdicional.Text = "Vendedor:";
                }
                else
                {
                    // MODO GERENTE: Usar ComboBox para selección
                    if (cmbVendedor != null)
                    {
                        cmbVendedor.Visible = value;
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
        }*/
        
       
        /* public bool FiltroVendedorHabilitado
         {
             set
             {
                 cmbVendedor.Enabled = value;
                 cmbVendedor.Visible = value;
                 txtVendedorAuto.Visible = !value;
             }
         }

         public int IdVendedorAutomatico
         {
             set
             {
                 // Para modo vendedor - seleccionar automáticamente
                 foreach (UsuarioModel item in cmbVendedor.Items)
                 {
                     if (item.Id_usuario == value)
                     {
                         cmbVendedor.SelectedItem = item;
                         break;
                     }
                 }
             }

         }*/
    }
}