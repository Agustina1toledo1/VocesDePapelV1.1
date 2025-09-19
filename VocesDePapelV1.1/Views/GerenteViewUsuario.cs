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
            //otros
        }

        //propiedades
        public string UsuarioId {
            get { return "0"; } //ver que pasa con esto
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
            get { return cmb_estado_usuario.Text; }
            set { cmb_estado_usuario.Text = value; }
        }
        public string UsuarioIdRol {
            get { return cmb_rol_usuario.Text; }
            set { cmb_rol_usuario.Text = value; }
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

            //throw new NotImplementedException();
        }
        //singleton patron (abre una sola instancia del formulario) 
        private static GerenteViewUsuario instance;
        public static GerenteViewUsuario GetInstance(Form parentConteiner)
        {
            if (instance == null || instance.IsDisposed) //si es nullo o esta desechado
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


    }
}
