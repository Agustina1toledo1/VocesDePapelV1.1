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
    public partial class ProductoSearchView2 : Form,  IProductoSearchView2
    {
        private string message;
        private bool isSuccessful;
        public ProductoSearchView2()
        {
            InitializeComponent();
        }

        public string Message {
            get { return message; }
            set { message = value; }
        }
        public bool IsSuccessful {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        public event EventHandler SelectEvent;
        public event EventHandler CancelEvent;

        public void SetProductoListBindingSource(object productoList)
        {
            dtg_productoSearch.DataSource = productoList;
        }
    }
}
