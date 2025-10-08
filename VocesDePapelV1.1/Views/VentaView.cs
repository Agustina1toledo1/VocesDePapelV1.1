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
    public partial class VentaView : Form, IVendedorVenta
    {
        public VentaView()
        {
            InitializeComponent();
            this.AutoScroll = true;
        }
        //singleton patron (abre una sola instancia del formulario) 
        private static VentaView instance;


        public static VentaView GetInstance(Form parentConteiner)
        {
            if (instance == null || instance.IsDisposed) //si es nulo o esta desechado
            {
                instance = new VentaView();
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

        private void BAgregarCliente_Click(object sender, EventArgs e)
        {
            // Instancia del formulario de cliente
            var clienteForm = VendedorViewCliente.GetInstance(this); // si usás patrón singleton
            clienteForm.Show(); // o ShowDialog() si querés bloquear la venta hasta que se cierre
        }
    }
}
