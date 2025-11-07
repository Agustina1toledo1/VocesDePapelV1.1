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
    public partial class VendedorView : Form, IVendedorView
    {
        public VendedorView()
        {
            InitializeComponent();
            ventaVendedorItemMenu.Click += delegate { ShowVentaView?.Invoke(this, EventArgs.Empty); };
            clienteVendedorItemMenu.Click += delegate { ShowClienteView?.Invoke(this, EventArgs.Empty); };
            reporteVentaVendedorItemMenu.Click += delegate { ShowReporteVentaView?.Invoke(this, EventArgs.Empty); };
            cerrarSVendedorItemMenu.Click += delegate { LogoutEvent?.Invoke(this, EventArgs.Empty); };
            MenuItemComprobanteVendedor.Click += delegate { ShowComprobanteView?.Invoke(this, EventArgs.Empty); };
        }
        public Form FormInstance => this;
        public event EventHandler ShowVentaView;
        public event EventHandler ShowClienteView;
        public event EventHandler ShowReporteVentaView;
        public event EventHandler LogoutEvent;
        public event EventHandler ShowComprobanteView;

        public void Cerrar()
        {
            this.Close();
        }

        public void Ocultar()
        {
            this.Hide();
        }
    }
}
