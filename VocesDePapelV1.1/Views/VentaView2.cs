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
    public partial class VentaView2 : Form, IVentaView2
    {
        public VentaView2()
        {
            InitializeComponent();
        }

        public string id_venta_cabecera { 
            get => throw new NotImplementedException(); set => throw new NotImplementedException(); 
        }
        public string fecha_hora_venta { 
            get => throw new NotImplementedException(); set => throw new NotImplementedException(); 
        }
        public string total_venta { 
            get => throw new NotImplementedException(); set => throw new NotImplementedException(); 
        }
        public string id_cliente { 
            get => throw new NotImplementedException(); set => throw new NotImplementedException(); 
        }
        public string id_usuario { 
            get => throw new NotImplementedException(); set => throw new NotImplementedException(); 
        }
        public string id_estado { 
            get => throw new NotImplementedException(); set => throw new NotImplementedException(); 
        }
        public string cliente_nombre { 
            get => throw new NotImplementedException(); set => throw new NotImplementedException(); 
        }
        public string vendedor_nombre { 
            get => throw new NotImplementedException(); set => throw new NotImplementedException(); 
        }
        public string estado_nombre { 
            get => throw new NotImplementedException(); set => throw new NotImplementedException(); 
        }
        public string message {
            get => throw new NotImplementedException(); set => throw new NotImplementedException(); 
        }
        public bool isSuccessful { 
            get => throw new NotImplementedException(); set => throw new NotImplementedException(); 
        }
        public string id_venta_detalle { 
            get => throw new NotImplementedException(); set => throw new NotImplementedException(); 
        }
        public string id_producto { 
            get => throw new NotImplementedException(); set => throw new NotImplementedException(); 
        }
        public string cantidad { 
            get => throw new NotImplementedException(); set => throw new NotImplementedException(); 
        }
        public string precio_unitario { 
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
        }
        public string subtotal { get => throw new NotImplementedException(); set => throw new NotImplementedException(); 
        }
        public string producto_nombre { 
            get => throw new NotImplementedException(); set => throw new NotImplementedException(); 
        }
        public string producto_stock { 
            get => throw new NotImplementedException(); set => throw new NotImplementedException(); 
        }
        public string searchValue { 
            get => throw new NotImplementedException(); set => throw new NotImplementedException(); 
        }
        public string cliente_cuit { 
            get => throw new NotImplementedException(); set => throw new NotImplementedException(); 
        }
        public string cliente_email { 
            get => throw new NotImplementedException(); set => throw new NotImplementedException(); 
        }
        public string cliente_telefono { 
            get => throw new NotImplementedException(); set => throw new NotImplementedException(); 
        }
        public string vendedor_cuit { 
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
        }

        public event EventHandler SearchClienteEvent;
        public event EventHandler SearchVendedorEvent;
        public event EventHandler SearchProductoEvent;
        public event EventHandler AddNewDetalleEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler SaveEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler DeleteAllEvent;
        public event EventHandler CancelEvent;
        public event EventHandler CancelAllEvent;

        public void SetVentaDetalleListBindingSource(object ventaDetalleList)
        {
            throw new NotImplementedException();
        }
    }
}
