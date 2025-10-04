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
            throw new NotImplementedException();
        }

        //singleton patron (abre una sola instancia del formulario) 
        private static AdministradorViewCategorias instance;

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public string CategoriaId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NombreCategoria { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Estado { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NombreEstado { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsSuccessful { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
