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
    public partial class GerenteViewUsuario : Form, IGerenteViewUsuario
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public GerenteViewUsuario()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents(); //asociar y generar los eventos de vistas
        }
        private void AssociateAndRaiseViewEvents()
        {
            //Buscar usuario
            btn_buscar_usuario.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); }; //al hacer clic (formulario, argumento de evento vacio)
            //con la tecla enter
            text_buscar_usuario.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            //Agregar nuevo usuario
            btn_guardar_usuario.Click += delegate { AddNewEvent?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
            };
            //editar usuario
            btn_modificar_usuario.Click += delegate {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    SaveEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            //eliminar usuario
            btn_eliminar_usuario.Click += delegate {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    var result = MessageBox.Show("Estas seguro de eliminar el usuario seleccionado?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        DeleteEvent?.Invoke(this, EventArgs.Empty);
                        MessageBox.Show(Message);

                    }
                }
                
            };
            dataGridView1.SelectionChanged += delegate
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    EditEvent?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    CancelEvent?.Invoke(this, EventArgs.Empty);
                }
                    
            };
            // Text box que solo admiten letras
            text_nombre_usuario.KeyPress += TextBoxSoloLetras_KeyPress;
            text_apellido_usuario.KeyPress += TextBoxSoloLetras_KeyPress;
            // Text box que solo admiten numeros
            text_cuit_usuario.KeyPress += TextBoxSoloNumeros_KeyPress;

        }

        private void TextBoxSoloNumeros_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' || (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
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

        //propiedades
        public string UsuarioId {
            get {
                if (dataGridView1.CurrentRow != null)
                    return dataGridView1.CurrentRow.Cells["Id_usuario"].Value?.ToString();
                return "0";
            } //ver que pasa con esto
            set {  }
        }
        public string UsuarioNombre {
            get { return text_nombre_usuario.Text; }
            set { text_nombre_usuario.Text = value; }
        }
        public string UsuarioApellido {
            get { return text_apellido_usuario.Text; }
            set { text_apellido_usuario.Text = value; }
        }
        public string Contraseña {
            get { return text_clave_usuario.Text; }
            set { text_clave_usuario.Text = value; }
        }
        public string CuitUsuario {
            get { return text_cuit_usuario.Text; }
            set { text_cuit_usuario.Text = value; }
        }
        public string Baja {
            get { return cmb_estado_usuario.SelectedValue?.ToString(); }
            set { cmb_estado_usuario.SelectedValue = value; }

        }
        public string UsuarioIdRol {
            get { return cmb_rol_usuario.SelectedValue?.ToString(); }
            set { cmb_rol_usuario.SelectedValue = value; }
        }
        
        public string SearchValue {
            get { return text_buscar_usuario.Text; }
            set { text_buscar_usuario.Text = value; }
        }

        
        public bool IsEdit {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message {
            get { return message; }
            set { message = value; }
        }

        public string NombreEstado {
            get { return cmb_estado_usuario.Text; }
            set { cmb_estado_usuario.Text = value; }
        }
        public string NombreRol {
            get { return cmb_rol_usuario.Text; }
            set { cmb_rol_usuario.Text = value; }
        }

        //Eventos
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //Metodos
        public void SetUsuarioListBindingSource(BindingSource usuarioList)
        {
            dataGridView1.DataSource = usuarioList;
            //ocultar los ids de estado y rol
            dataGridView1.Columns["Id_rol"].Visible = false;
            dataGridView1.Columns["Baja"].Visible = false;
            dataGridView1.Columns["Contraseña"].Visible = false;

        }
        //singleton patron (abre una sola instancia del formulario) 
        private static GerenteViewUsuario instance;
        public static GerenteViewUsuario GetInstance(Form parentConteiner)
        {
            if (instance == null || instance.IsDisposed) //si es nulo o esta desechado
            {
                instance = new GerenteViewUsuario();
                instance.MdiParent = parentConteiner; //establecer el formulario padre
                instance.FormBorderStyle = FormBorderStyle.None; //sin bordes
                instance.Dock = DockStyle.Fill; //llenar el contenedor
            }
            else
            {
                if(instance.WindowState == FormWindowState.Minimized)//si esta minimizado, restaurar
                {
                    instance.WindowState = FormWindowState.Normal; 
                }
                instance.BringToFront();//si ya existe, traer al frente

            } 
            return instance;
        }

        public void SetEstadoListBindingSource(BindingSource estadoList)
        {
            cmb_estado_usuario.DataSource = estadoList;
            cmb_estado_usuario.DisplayMember = "Nombre_estado"; 
            cmb_estado_usuario.ValueMember = "Id_estado";
        }

        public void SetRolListBindingSource(BindingSource rolList)
        {
            cmb_rol_usuario.DataSource = rolList;
            cmb_rol_usuario.DisplayMember = "Nombre_rol";
            cmb_rol_usuario.ValueMember = "Id_rol";
        }
    }
}
