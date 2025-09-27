using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocesDePapelV1._1.Views { 

    public partial class GerenteView : Form, IGerenteView
    {
        public GerenteView()
        {
            InitializeComponent();
            usuarioItemMenu.Click += delegate { ShowUsuarioView?.Invoke(this, EventArgs.Empty); };
            backupItemMenu.Click += delegate { ShowBackupView?.Invoke(this, EventArgs.Empty); };
            reporteVentaGerenteItemMenu.Click += delegate { ShowReporteVentaView?.Invoke(this, EventArgs.Empty); };
            reporteLSGerenteItemMenu.Click += delegate { ShowReporteLibroStockView?.Invoke(this, EventArgs.Empty); };
            reporteLMVGerenteItemMenu.Click += delegate { ShowReporteLibroMasVendidosView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowUsuarioView;
        public event EventHandler ShowBackupView;
        public event EventHandler ShowReporteVentaView;
        public event EventHandler ShowReporteLibroStockView;
        public event EventHandler ShowReporteLibroMasVendidosView;
    }
    
}
