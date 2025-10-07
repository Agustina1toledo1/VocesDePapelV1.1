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
            //buscar categoria
            btn_buscar_categoria.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); }; //al hacer clic (formulario, argumento de evento vacio)
            text_buscar_categoria.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            //eliminar categoria
            btn_eliminar_categoria.Click += delegate {
                if (datgridCategorias.SelectedCells.Count > 0)
                {
                    var result = MessageBox.Show("Estas seguro de eliminar el usuario seleccionado?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        DeleteEvent?.Invoke(this, EventArgs.Empty);
                        MessageBox.Show(Message);

                    }
                }

            };
            btn_modificar_categoria.Click += delegate {
                if (datgridCategorias.SelectedCells.Count > 0)
                {
                    SaveEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

        
            datgridCategorias.SelectionChanged += delegate
            {
                if (datgridCategorias.SelectedCells.Count > 0)
                {
                    EditEvent?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    CancelEvent?.Invoke(this, EventArgs.Empty);
                }

            };
            text_nombre_categoria_admin.KeyPress += TextBoxSoloLetras_KeyPress;
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
                if (datgridCategorias.CurrentRow != null)
                    return datgridCategorias.CurrentRow.Cells["Id_categoria"].Value?.ToString();
                return "0";
            } //ver que pasa con esto
            set { }
        }
        public string NombreCategoria { 
            get { return text_nombre_categoria_admin.Text; }
            set { text_nombre_categoria_admin.Text = value; }
        }
        public string Estado_id { 
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

        private void TextBoxSoloLetras_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // si es: 
            //  - Espacios, caracteres especiales char.IsControl
            //  - Letras y letras con acento => char.IsLetter
            //  - Espacio => e.KeyChar == ' '
            if (!char.IsControl(e.KeyChar)
                && !char.IsLetter(e.KeyChar)
                && e.KeyChar != ' ')
            {
                // Bloquea la tecla
                e.Handled = true;
            }
        }
        public void SetCategoriaListBindingSource(BindingSource categoriaList)
        {
            datgridCategorias.DataSource = categoriaList;
            //ocultar los ids de estado, rol y contraseña
            datgridCategorias.Columns["Id_categoria"].Visible = false;
            datgridCategorias.Columns["Estado_id"].Visible = false;

            // dataGridView1.Columns["Contraseña"].Visible = false;
        }

        public void SetEstadoListBindingSource(BindingSource estadoList)
        {
            cmb_estado_categoria.DataSource = estadoList;
            cmb_estado_categoria.DisplayMember = "Nombre_estado";
            cmb_estado_categoria.ValueMember = "Id_estado";

        }
    }
}
