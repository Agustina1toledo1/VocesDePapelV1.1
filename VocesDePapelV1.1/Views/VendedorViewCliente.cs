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
       
        //singleton patron (abre una sola instancia del formulario) 
        private static VendedorViewCliente instance;
        // Eventos
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public VendedorViewCliente()
        {
            InitializeComponent();
            this.AutoScroll = true;
            AssociateAndRaiseViewEvents(); //asociar y generar los eventos de vistas
        }
        private void AssociateAndRaiseViewEvents()
        {

            // Buscar
            btn_buscar_cliente.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            // Nuevo cliente (prepara el formulario)
            btn_guardar_cliente.Click += delegate {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                    MessageBox.Show(this.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(this.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            // Modificar cliente (carga datos en el formulario)
            btn_modificar_cliente.Click += delegate { EditEvent?.Invoke(this, EventArgs.Empty); };

            // Eliminar cliente con confirmación
            btn_eliminar_cliente.Click += delegate {
                var result = MessageBox.Show("¿Está seguro de eliminar el cliente seleccionado?", "Advertencia",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(this.Message); // Muestra el resultado de la operación
                }
            };

            // Limpiar formulario
            btn_limpiar_cliente.Click += delegate { CancelEvent?.Invoke(this, EventArgs.Empty); };

            // Nuevo cliente (opcional si tenés un botón específico para "Nuevo")
            // btn_nuevo_cliente.Click += delegate { AddNewEvent?.Invoke(this, EventArgs.Empty); };
        }
        //propiedades
        public string ClienteId
        {
            get
            {
                if (DGVListCliente.CurrentRow != null)
                    return DGVListCliente.CurrentRow.Cells["Id_cliente"].Value?.ToString();
                return "0";
            } 
            set { }
        }
        public string NombreRazonSocial
        {
            get { return TBCliente.Text; }
            set { TBCliente.Text = value; }
        }
        public string CuitCuil
        {
            get { return TBCuitCuil.Text; }
            set { TBCuitCuil.Text = value; }
        }
        string IVendedorCliente.Telefono
        {
            get { return TBTelefonoCliente.Text; }
            set { TBTelefonoCliente.Text = value; }
        }
        public string Email
        {
            get { return TBEmailCliente.Text; }
            set { TBEmailCliente.Text = value; }
        }

        public string SearchValue
        {
            get { return btn_buscar_cliente.Text; }
            set { btn_buscar_cliente.Text = value; }
        }


        // Propiedades de estado de la operación
        public bool IsEdit { get; set; }
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }
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

        // Método para enlazar el DataGridView
        public void SetClienteListBindingSource(BindingSource clienteList)
        {
            DGVListCliente.DataSource = clienteList;
        }

        public void Show()
        {
            base.Show();
        }
        private void btn_volver_cliente_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual
            this.Close();

            // Muestra el formulario de ventas
            var ventasForm =VentaView.GetInstance(this.MdiParent);
            ventasForm.Show();
        }
    }
}
