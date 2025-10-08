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
    public partial class VendedorViewCliente : Form, IVendedorCliente
    {
        public VendedorViewCliente()
        {
            InitializeComponent();
            this.AutoScroll = true;
            AsociarEventos(); //asociar y generar los eventos de vistas
        }
        //singleton patron (abre una sola instancia del formulario) 
        private static VendedorViewCliente instance;

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //propiedades
        public string ClienteId { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public string NombreRazonSocial { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public string CuitCuil { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        string IVendedorCliente.Telefono { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public string Email { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public string SearchValue => throw new NotImplementedException();

        public bool IsEdit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsSuccessful { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public static VendedorViewCliente GetInstance(Form parentConteiner)
        {
            if (instance == null || instance.IsDisposed) //si es nulo o esta desechado
            {
                instance = new VendedorViewCliente();
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

        
        private void AsociarEventos()
        {
            //BBuscarCliente.Click += (s, e) => SearchEvent?.Invoke(s, e);
            //BAgregarCliente.Click += (s, e) => AddNewEvent?.Invoke(s, e);
           
        }
        public void SetClienteListBindingSource(BindingSource clienteList)
        {
            throw new NotImplementedException();
        }
    }
}
