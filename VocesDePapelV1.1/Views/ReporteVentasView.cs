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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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

           get { return !cmbTipoReporte.Enabled && !cmbVendedor.Enabled; }
        set
        { cmbTipoReporte.Enabled = value;
            if (value)
            {
                // ✅ MODO VENDEDOR - Configuración correcta
                cmbTipoReporte.Enabled = false;      // Deshabilita cambiar tipo
                cmbTipoReporte.SelectedItem = "Por Vendedor"; // Fuerza tipo "Por Vendedor"
                cmbVendedor.Enabled = false;         // Deshabilita cambiar vendedor
                cmbBusqueda.Enabled = false;         // Deshabilita búsqueda general
                lblTipoReporte.Text = "Modo Vendedor"; // Cambia etiqueta
            }
            else
            {
                // ✅ MODO GERENTE - Configuración correcta
                cmbTipoReporte.Enabled = true;       // Habilita cambiar tipo
                cmbVendedor.Enabled = true;          // Habilita cambiar vendedor
                cmbBusqueda.Enabled = true;          // Habilita búsqueda general
                lblTipoReporte.Text = "Tipo Reporte:"; // Etiqueta normal
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
      
        public string ValorBusqueda
        {
            get
            {
                if (cmbBusqueda.SelectedValue != null)
                    return cmbBusqueda.SelectedValue.ToString();
                return cmbBusqueda.Text;
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
                cmbBusqueda.DataSource = value;
                cmbBusqueda.DisplayMember = "NombreCompleto";
                cmbBusqueda.ValueMember = "Id_usuario";
            }
        }
        //
        public int? IdVendedorSeleccionado
        {
            get
            {
                return cmbBusqueda.SelectedValue as int?;
            }
        }
       public int? IdClienteSeleccionado
        {
            get
            {
                return cmbBusqueda.SelectedValue as int?;
            }
        }

        public List<ClienteModel> ListaClientes
        {
            set
            {
                cmbBusqueda.DataSource = value;
                cmbBusqueda.DisplayMember = "Nombre_razon_social";
                cmbBusqueda.ValueMember = "id_cliente"; // O "Id_cliente" según tu modelo
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
        public string CmbBusqueda { get ; set ; }


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
            if (instance != null && !instance.IsDisposed)
            {
                // 1. FORZAR CIERRE Y DESTRUCCIÓN
                // Si la encontramos, la cerramos y la liberamos para forzar la re-creación.
                try
                {
                    // Usar Close() para disparar eventos de cierre si es necesario
                    instance.Close();
                }
                catch { /* Ignorar si ya está cerrándose */ }

                // 2. Liberar recursos inmediatamente (crucial en Singleton si no usamos FormClosed)
                // instance.Dispose(); // Close() generalmente llama a Dispose()

                // 3. Establecer la instancia a null para que el siguiente bloque la cree.
                instance = null;
            }

            // 4. CREAR NUEVA INSTANCIA (Esto se ejecuta después de que la anterior fue destruida)
            if (instance == null || instance.IsDisposed)
            {
                instance = new ReporteVentasView();
                //instance.MdiParent = parent; // Configura el padre MDI si lo usas
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