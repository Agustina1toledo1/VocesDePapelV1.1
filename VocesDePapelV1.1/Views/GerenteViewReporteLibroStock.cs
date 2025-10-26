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
        private string message;
        private bool isSuccessful;
        public GerenteViewReporteLibroStock()
        {
            InitializeComponent();
            this.AutoScroll = true;
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            //Buscar libros con stock menor o igual
            btn_buscar_stock.Click += delegate { 
                SearchEvent?.Invoke(this, EventArgs.Empty); 
            }; //al hacer clic (formulario, argumento de evento vacio)
            //con la tecla enter
            if (txt_buscar_stock_reporte_producto == null)
                MessageBox.Show("El control text_stock_reporte_gerente no está inicializado.");
            else
                txt_buscar_stock_reporte_producto.KeyDown += (s, e) =>
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        SearchEvent?.Invoke(this, EventArgs.Empty);
                    }
                };
        }

        //singleton patron (abre una sola instancia del formulario) 
        private static GerenteViewReporteLibroStock instance;

        public string StockMinimo
        { 
            get { return txt_buscar_stock_reporte_producto.Text; }
            set { txt_buscar_stock_reporte_producto.Text = value; }
        }

        public string Message {
            get { return message; }
            set { message = value; }
        }
        public bool IsSuccessful {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        public event EventHandler GenerateReportEvent;
        public event EventHandler SearchEvent;

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


        public void SetProductoFiltradoListBindingSource(object productoList)
        {
            dataGridViewReporteStock.DataSource = productoList;
        }
        public void SetCategoriaListBindingSource(object categoriaList)
        {
            throw new NotImplementedException();
        }

        public void SetEstadoListBindingSource(object estadoList)
        {
            throw new NotImplementedException();
        }

        public void SetAutorListBindingSource(object autorList)
        {
            throw new NotImplementedException();
        }

        
    }
}
