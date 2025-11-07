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
            "Top 10 Ventas"
        });
            cmbTipoReporte.SelectedIndex = 0;
        }
        private static ReporteVentasView instance;
        private void AssociateAndRaiseViewEvents()
        {

            btnBuscar.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };//  Evento Buscar

            btnGenerarPDF.Click += delegate { GenerateReportEvent?.Invoke(this, EventArgs.Empty); };//Evento Generar PDF

            btnLimpiar.Click += delegate { LimpiarFiltrosEvent?.Invoke(this, EventArgs.Empty); };//Evento Limpiar
            cmbTipoReporte.SelectedIndexChanged += cmbTipoReporte_SelectedIndexChanged;

        }
        // Propiedades para saber el tipo de usuario
<<<<<<< HEAD
       /* public bool EsModoVendedor
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
        }*/


        // Propiedades  para filtros
=======
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
>>>>>>> se agrega acceso a reporte de ventas para vendedor con  filtro restringido
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
            get => cmbTipoReporte.SelectedItem?.ToString() ?? "Por Fecha";
            set => cmbTipoReporte.SelectedItem = value;
        }
<<<<<<< HEAD
=======

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

>>>>>>> se agrega acceso a reporte de ventas para vendedor con  filtro restringido
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
        public object DatosComboBusqueda
        {
            set
            {
                if (cmbBusqueda != null)
                {
                    cmbBusqueda.DataSource = value;
                    cmbBusqueda.DisplayMember = "Nombre"; // O la propiedad a mostrar
                    cmbBusqueda.ValueMember = "Id"; // O la propiedad del valor
                }
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
            get {
                return listaVendedores;
            }
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
                return cmbBusqueda.SelectedValue as int?;
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
        int? IGerenteViewReporteVentas.IdVendedorSeleccionado {
            get
            {
                // Lógica para OBTENER el ID del vendedor seleccionado
                if (cmbBusqueda.SelectedValue != null &&
                    cmbBusqueda.SelectedValue != DBNull.Value)
                {
                    if (cmbBusqueda.SelectedValue is int id)
                    {
                        return id;
                    }
                    else if (int.TryParse(cmbBusqueda.SelectedValue.ToString(), out id))
                    {
                        return id;
                    }
                }
                return null;
            }
            set
            {
                // Lógica para ESTABLECER el vendedor seleccionado
                if (value.HasValue)
                {
                    try
                    {
                        // Buscar el vendedor en el ComboBox
                        foreach (var item in cmbBusqueda.Items)
                        {
                            if (item is UsuarioModel usuario && usuario.Id_usuario == value.Value)
                            {
                                cmbBusqueda.SelectedItem = item;
                                return;
                            }
                        }

                        // Si no lo encuentra por objeto, intentar por valor
                        cmbBusqueda.SelectedValue = value.Value;
                    }
                    catch (Exception ex)
                    {
                        // Log del error si es necesario
                        Console.WriteLine($"Error al seleccionar vendedor: {ex.Message}");
                    }
                }
                else
                {
                    // Si no hay valor, deseleccionar
                    cmbBusqueda.SelectedIndex = -1;
                }
            }
        }
        List<UsuarioModel> IGerenteViewReporteVentas.DatosComboBusqueda { get => throw new NotImplementedException(); set => DatosComboBusqueda = value; }

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
      
        private readonly List<UsuarioModel> listaVendedores;

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
<<<<<<< HEAD
        /*public bool FiltroVendedorVisible
=======
        public bool FiltroVendedorVisible
>>>>>>> se agrega acceso a reporte de ventas para vendedor con  filtro restringido
        {
            get
            {
                // Verificar si los controles del filtro están visibles
                return lblFiltroAdicional.Visible &&
<<<<<<< HEAD
                       (cmbVendedor != null ? cmbVendedor.Visible );
=======
                       (cmbVendedores != null ? cmbVendedores.Visible : txtFiltroAdicional.Visible);
>>>>>>> se agrega acceso a reporte de ventas para vendedor con  filtro restringido
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
<<<<<<< HEAD
                    if (cmbVendedor != null)
                    {
                        cmbVendedor.Visible = false;
=======
                    if (cmbVendedores != null)
                    {
                        cmbVendedores.Visible = false;
>>>>>>> se agrega acceso a reporte de ventas para vendedor con  filtro restringido
                    }
                    lblFiltroAdicional.Text = "Vendedor:";
                }
                else
                {
                    // MODO GERENTE: Usar ComboBox para selección
<<<<<<< HEAD
                    if (cmbVendedor != null)
                    {
                        cmbVendedor.Visible = value;
=======
                    if (cmbVendedores != null)
                    {
                        cmbVendedores.Visible = value;
>>>>>>> se agrega acceso a reporte de ventas para vendedor con  filtro restringido
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
<<<<<<< HEAD
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
=======
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
>>>>>>> se agrega acceso a reporte de ventas para vendedor con  filtro restringido
    }
}