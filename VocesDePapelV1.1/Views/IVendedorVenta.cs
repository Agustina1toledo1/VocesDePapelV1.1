using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace VocesDePapelV1._1.Views
{
    public interface IVendedorVenta
    {
        event EventHandler AddNewClienteEvent;
        event EventHandler EditarClienteEvent;
        event EventHandler SearchClienteByCuitEvent;
        event EventHandler ClearClienteEvent;
        event EventHandler SearchVendedorByCuitEvent;
        event EventHandler ClearVentaEvent;
        Form FormInstance { get; }
        //propiedades del cliente
        string ClienteCuit { get; set; }
        string ClienteNombre { get; set; }
        string ClienteEmail { get; set; }
        string ClienteTelefono { get; set; }
        // propiedades del vendedor
        string VendedorCuit { get; set; }
        string VendedorNombre { get; set; }

        // propiedades de producto
        /*string CodigoProducto { get; set; }
        string PrecioProducto { get; set; }
        string StockProducto { get; set; }
        string CantidadProducto { get; set; }
        string PrecioTotal { get; set; }*/

        // propiedad para el número de factura
        string NumeroFactura { get; set; }


        void LimpiarListaProductos();
        object ProductosDataSource { get; set; }

        void Show();
    }
}
