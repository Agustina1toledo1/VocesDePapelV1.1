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

    public partial class GerenteView : Form, IGerenteView // <-- ERROR: IGerenteView es una clase, no una interfaz
    {
        public GerenteView()
        {
            InitializeComponent();
        }
    }
    // Cambia la clase a interfaz
    public interface IGerenteView
    {
        event EventHandler ShowUsuarioView;
        event EventHandler ShowBackupView;
        event EventHandler ShowReporteVentaView;
        event EventHandler ShowReporteLibroView;
    }
}
