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

        }

        public event EventHandler ShowProductoView;
        public event EventHandler ShowReporteLibroStockView;
        public event EventHandler ShowReporteLibroMasVendidosView;
        public event EventHandler ShowAutoresView;
        public event EventHandler ShowCategoriasView;
    }
}
