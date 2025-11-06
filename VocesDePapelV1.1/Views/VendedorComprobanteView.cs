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
    public partial class VendedorComprobanteView : Form, IVendedorComprobanteView
    {
        private string message;
        private bool isSuccessful;
        public VendedorComprobanteView()
        {
            InitializeComponent();
            this.AutoScroll = true;
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            throw new NotImplementedException();
        }

        public string SearchNumeroComprobante
        {
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
        }
        public string Message
        {
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
        }
        public bool IsSuccessful
        {
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
        }

        public event EventHandler SearchComprobanteEvent;
        public event EventHandler ShowComprobanteEvent;

        public void SetComprobanteFiltradoListBindingSource(object comprobanteList)
        {
            throw new NotImplementedException();
        }

        
        
    }
}
