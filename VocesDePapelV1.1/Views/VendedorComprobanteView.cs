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
    public partial class VendedorComprobanteView : Form, IVendedorComprobanteView
    {
        private string message;
        private bool isSuccessful;
        public VendedorComprobanteView()
        {
            InitializeComponent();
            this.AutoScroll = true;
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            btn_buscar_comprobante.Click +=  delegate
            {
                SearchComprobanteEvent?.Invoke(this, EventArgs.Empty);
            };
            text_buscar_comprobante.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchComprobanteEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            dataGridViewCabecera.SelectionChanged += delegate
            {
                if (dataGridViewCabecera.SelectedCells.Count > 0)
                {
                    LoadEvent?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        public string SearchNumeroComprobante
        {
            get { return text_buscar_comprobante.Text; }
            set { text_buscar_comprobante.Text = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        public event EventHandler SearchComprobanteEvent;
        public event EventHandler GenerarPDFEvent;
        public event EventHandler LoadEvent;


        //singleton patron (abre una sola instancia del formulario) 
        private static VendedorComprobanteView instance;

        public static VendedorComprobanteView GetInstance(Form parentConteiner)
        {
            if (instance == null || instance.IsDisposed) //si es nulo o esta desechado
            {
                instance = new VendedorComprobanteView();
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
        public void SetComprobanteListBindingSource(object comprobanteList)
        {
            dataGridViewCabecera.DataSource = comprobanteList;
            dataGridViewCabecera.Columns["Id_cliente"].Visible = false;
            dataGridViewCabecera.Columns["Id_usuario"].Visible = false;
            dataGridViewCabecera.Columns["Id_estado"].Visible = false;
        }

        public void SetComprobanteDetalleListBindingSource(object comprobanteDetalleList)
        {
            dataGridViewDetalle.DataSource = comprobanteDetalleList;
        }
    }
}
