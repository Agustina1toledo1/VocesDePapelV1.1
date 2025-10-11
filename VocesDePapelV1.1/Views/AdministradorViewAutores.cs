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
    public partial class AdministradorViewAutores : Form, IAdministradorAutor
    {
        private string message;
        private bool isSuccessful;
        public AdministradorViewAutores()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents(); //asociar y generar los eventos de vistas
        };

        private void AssociateAndRaiseViewEvents()
        {
            btn_registrar_autor.Click += delegate { 
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
            };
            //buscar autor
            btn_buscar_autor.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); }; //al hacer clic (formulario, argumento de evento vacio)
            text_buscar_autor.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            //eliminar autor
            btn_eliminar_autor.Click += delegate {
                if (dataGridAutorAdmin.SelectedCells.Count > 0)
                {
                    var result = MessageBox.Show("Estas seguro de eliminar el autor seleccionado?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        DeleteEvent?.Invoke(this, EventArgs.Empty);
                        MessageBox.Show(Message);
                    }
                }
            };
            //modificar autor
            btn_modificar_autor.Click += delegate {
                if (dataGridAutorAdmin.SelectedCells.Count > 0)
                {
                    SaveEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
            //mostrar datos en los textbox al seleccionar una fila del datagrid
            dataGridAutorAdmin.SelectionChanged += delegate
            {
                if (dataGridAutorAdmin.SelectedCells.Count > 0)
                {
                    EditEvent?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    CancelEvent?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        //singleton patron (abre una sola instancia del formulario) 
        private static AdministradorViewAutores instance;

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public string AutorId {
            get
            {
                if (dataGridAutorAdmin.CurrentRow != null)
                    return dataGridAutorAdmin.CurrentRow.Cells["Id_autor"].Value?.ToString();
                return "0";
            } //ver que pasa con esto
            set { }
        }
        public string AliasAutor {
            get { return text_nombre_autor_admin.Text; }
            set { text_nombre_autor_admin.Text = value; }
        }
        public string Estado_id {
            get { return cmb_estado_autor.SelectedValue?.ToString(); }
            set { cmb_estado_autor.SelectedValue = value; }
        }
        public string NombreEstado {
            get { return cmb_estado_autor.Text; }
            set { cmb_estado_autor.Text = value; }
        }
        public string SearchValue {
            get { return text_buscar_autor.Text; }
            set { text_buscar_autor.Text = value; }
        }
        public bool IsSuccessful {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message {
            get { return message; }
            set { message = value; }
        }

        public static AdministradorViewAutores GetInstance(Form parentConteiner)
        {
            if (instance == null || instance.IsDisposed) //si es nulo o esta desechado
            {
                instance = new AdministradorViewAutores();
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

        public void SetAutorListBindingSource(BindingSource autorList)
        {
            dataGridAutorAdmin.DataSource = autorList;
            //ocultar los ids de estado, rol y contraseña
            //dataGridAutorAdmin.Columns["Id_categoria"].Visible = false;
            //dataGridAutorAdmin.Columns["Estado_id"].Visible = false;
        }

        public void SetEstadoListBindingSource(BindingSource estadoList)
        {
            cmb_estado_autor.DataSource = estadoList;
            cmb_estado_autor.DisplayMember = "Nombre_estado";
            cmb_estado_autor.ValueMember = "Id_estado";

        }
    }
}
