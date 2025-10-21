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
    public partial class GerenteViewReporteLibroStock : Form, IGerenteReporteLibroStock
    {
        public GerenteViewReporteLibroStock()
        {
            InitializeComponent();
        }

        //singleton patron (abre una sola instancia del formulario) 
        private static GerenteViewReporteLibroStock instance;

        public event EventHandler SearchEvent;
        public event EventHandler GenerateReportEvent;

        public string FiltroCantidad {
            get { return text_cantidad_libro_reporte_gerente.Text; }
            set { text_cantidad_libro_reporte_gerente.Text = value; }
        }
        public string CantidadTotalLibros {
            get { return l_resultadoTotalProductoStock.Text; }
            set { l_resultadoTotalProductoStock.Text = value; }
        }

        public static GerenteViewReporteLibroStock GetInstance(Form parentConteiner)
        {
            if (instance == null || instance.IsDisposed) //si es nulo o esta desechado
            {
                instance = new GerenteViewReporteLibroStock();
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

        public void SetProductoListBindingSource(object productoList)
        {
            throw new NotImplementedException();
        }
    }
}
