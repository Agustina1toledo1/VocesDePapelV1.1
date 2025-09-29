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
    public partial class AdministradorView : Form, IAdministradorView
    {
        public AdministradorView()
        {
            InitializeComponent();
            //Asignar eventos a los botones
            producto_item_menu_admin.Click += delegate { ShowProductoView?.Invoke(this, EventArgs.Empty); };
            reporte_venta_item_menu_admin.Click += delegate { ShowReporteVentaView?.Invoke(this, EventArgs.Empty); };
            reporteLibroSAdminItemMenu.Click += delegate { ShowReporteLibroStockView?.Invoke(this, EventArgs.Empty); };
            ReporteMasVendidoLibroItemMenuAdmin.Click += delegate { ShowReporteLibroMasVendidosView?.Invoke(this, EventArgs.Empty); };
            autor_item_menu_admin.Click += delegate { ShowAutoresView?.Invoke(this, EventArgs.Empty); };
            categorias_menu_item_admin.Click += delegate { ShowCategoriasView?.Invoke(this, EventArgs.Empty); };
            cerrarSAdminItemMenu.Click += delegate { LogoutEvent?.Invoke(this, EventArgs.Empty); };

        }

        public bool LogoutSolicitado => throw new NotImplementedException();
        

        public event EventHandler ShowProductoView;
        public event EventHandler ShowReporteLibroStockView;
        public event EventHandler ShowReporteLibroMasVendidosView;
        public event EventHandler ShowAutoresView;
        public event EventHandler ShowCategoriasView;
        public event EventHandler ShowReporteVentaView;
        public event EventHandler LogoutEvent;


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
