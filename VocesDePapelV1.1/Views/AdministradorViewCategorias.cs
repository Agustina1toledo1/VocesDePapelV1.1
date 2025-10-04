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
    public partial class AdministradorViewCategorias : Form, IAdministradorCategoria
    {
        private string message;
        private bool isSuccessful;
        public AdministradorViewCategorias()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents(); //asociar y generar los eventos de vistas
        }

        private void AssociateAndRaiseViewEvents()
        {
            btn_registrar_categoria.Click += delegate { AddNewEvent?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
            };
        }

        //singleton patron (abre una sola instancia del formulario) 
        private static AdministradorViewCategorias instance;

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public string CategoriaId {
            get
            {
                if (dataGridView1.CurrentRow != null)
                    return dataGridView1.CurrentRow.Cells["Id_categoria"].Value?.ToString();
                return "0";
            } //ver que pasa con esto
            set { }
        }
        public string NombreCategoria { 
            get { return text_nombre_categoria_admin.Text; }
            set { text_nombre_categoria_admin.Text = value; }
        }
        public string Estado { 
            get {return cmb_estado_categoria.SelectedValue?.ToString(); }
            set { cmb_estado_categoria.SelectedValue = value; }
        }
        public string NombreEstado {
            get { return cmb_estado_categoria.Text; }
            set { cmb_estado_categoria.Text= value; }
        }
        public string SearchValue {
            get { return text_buscar_categoria.Text; }
            set { text_buscar_categoria.Text = value; }
        }
        public bool IsSuccessful {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message {
            get { return message; }
            set { message = value; }
        }

        public static AdministradorViewCategorias GetInstance(Form parentConteiner)
        {
            if (instance == null || instance.IsDisposed) //si es nulo o esta desechado
            {
                instance = new AdministradorViewCategorias();
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

        public void SetCategoriaListBindingSource(BindingSource usuarioList)
        {
            throw new NotImplementedException();
        }

        public void SetEstadoListBindingSource(BindingSource estadoList)
        {
            throw new NotImplementedException();
        }
    }
}
