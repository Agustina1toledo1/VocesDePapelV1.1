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
        public string Clave {
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

    
    }
}
