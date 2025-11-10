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
    public partial class GerenteViewReporteLibroMasVendidos : Form, IGerenteReporteLibroMasVendidos
    {
        private string message;
        private bool isSuccessful;
        public GerenteViewReporteLibroMasVendidos()
        {
            InitializeComponent();
            this.AutoScroll = true;
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            //buscar libros mas vendidos
            btnBuscarReporteLibroMV.Click += delegate {
                SearchEvent?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
            };
            //generar reporte en PDF
            btn_generar_pdf_reporteLibroMV.Click += delegate {
                GenerateReportEvent?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
            };

        }

        //singleton patron (abre una sola instancia del formulario) 
        private static GerenteViewReporteLibroMasVendidos instance;

        public event EventHandler GenerateReportEvent;
        public event EventHandler SearchEvent;

        public DateTime FechaInicio {
            get { return dTPFechaInicioReporteLibroMV.Value.Date ; }
            set {
                if (DateTime.TryParse(value.ToString(), out DateTime fecha))
                    dTPFechaInicioReporteLibroMV.Value = fecha;
            }
        }
        public DateTime FechaFin {
            get { return dTPFechaFinReporteLibroMV.Value.Date; }
            set
            {
                if (DateTime.TryParse(value.ToString(), out DateTime fecha))
                    dTPFechaFinReporteLibroMV.Value = fecha;
            }
        }
        public string Message {
            get { return message; }
            set { message = value; }
        }
        public bool IsSuccessful {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string CantidaLibrosVendidos {
            get { return txtBCatidadReporteLibroMV.Text; }
            set { txtBCatidadReporteLibroMV.Text = value; }
        }

        public string CategoriaMasVendidaLabel {
            set { lCategoriaMV.Text = value; }
        }
        public string TotalRecaudadoLabel {

            set { lTotalVentasMV.Text = value; }
        }

        public static GerenteViewReporteLibroMasVendidos GetInstance(Form parentConteiner)
        {
            if (instance == null || instance.IsDisposed) //si es nulo o esta desechado
            {
                instance = new GerenteViewReporteLibroMasVendidos();
                instance.MdiParent = parentConteiner; //establecer el formulario padre
                instance.FormBorderStyle = FormBorderStyle.None; //sin bordes
                instance.Dock = DockStyle.Fill; //llenar el contenedor
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

        public void SetLibroMasVendidoListBindingSource(object libroMasVendidoList)
        {
            dGVReporteLibroMV.DataSource = libroMasVendidoList;
            dGVReporteLibroMV.Columns["Id_categoria"].Visible = false;
            dGVReporteLibroMV.Columns["Id_autor"].Visible = false;
            dGVReporteLibroMV.Columns["Eliminado_id"].Visible = false;
        }
    }
}
