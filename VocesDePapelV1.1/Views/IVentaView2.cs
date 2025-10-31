using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace VocesDePapelV1._1.Views
{
    public interface IVentaView2
    {
        //propiedades de la tabla cabecera venta
        string id_venta_cabecera { get; set; }
        string fecha_hora_venta { get; set; }
        string total_venta { get; set; }
        string id_cliente { get; set; }
        string id_usuario { get; set; }
        string id_estado { get; set; }
        string cliente_nombre { get; set; }
        string cliente_cuit { get; set; }
        string cliente_email { get; set; }
        string cliente_telefono { get; set; }
        string vendedor_nombre { get; set; }
        string vendedor_cuit { get; set; }
        string estado_nombre { get; set; }
        string message { get; set; }
        bool isSuccessful { get; set; }


        //propiedades de la tabla detalle venta
        string id_venta_detalle { get; set; }
        string id_producto { get; set; }
        string cantidad { get; set; }
        string precio_unitario { get; set; }
        string subtotal { get; set; }

        //propiedades de la tabla producto
        string producto_nombre { get; set; }
        string producto_stock { get; set; }
        string searchValue { get; set; }


        //eventos
        event EventHandler SearchClienteEvent;
        event EventHandler SearchVendedorEvent;
        //event EventHandler LoadEvent;
        event EventHandler SearchProductoEvent;
        event EventHandler AddNewDetalleEvent;//añade un detalle a la venta
        event EventHandler AddNewEvent;//añade la venta completa
        event EventHandler SaveEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent; //Eliminar un detalle de la venta
        event EventHandler DeleteAllEvent; //eliminar todos los detalles de la venta
        event EventHandler CancelAllEvent; //limpiar todos los campos de la venta


        //metodos
        //enlace a los detalles de la venta
        void SetVentaDetalleListBindingSource(object ventaDetalleList);
        void Show();

    }
}
