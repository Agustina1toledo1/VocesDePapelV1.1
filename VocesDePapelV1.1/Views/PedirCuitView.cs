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
    public partial class Cuit : Form
    {
        public string CuitIngresado { get; private set; }
        public Cuit()
        {
            InitializeComponent();
            this.AcceptButton = BtnAceptar;
        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.CuitIngresado = txtCuit.Text; // Asigna el valor
            this.DialogResult = DialogResult.OK; 
            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
