using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Views
{
    public interface IVentaView2
    {
        //propiedades de la tabla cabecera venta
        string Total_venta { get; set; }
        string Id_cliente { get; set; }
        string Id_usuario { get; set; }
        string Id_estado { get; set; }
        string Cliente_nombre { get; set; }
        string Cliente_cuit { get; set; }
        string Cliente_email { get; set; }
        string Cliente_telefono { get; set; }
        string Vendedor_nombre { get; set; }
        string Vendedor_cuit { get; set; }
        string Estado_nombre { get; set; }
        string Message { get; set; }
        bool IsSuccessful { get; set; }


        //propiedades de la tabla detalle venta
        string Id_venta_detalle { get; set; }
        string Id_producto { get; set; }
        string Cantidad { get;}
        string Precio_unitario { get; set; }
        string Subtotal { get; set; }

        //propiedades de la tabla producto
        string Producto_nombre { get; set; }
        string Producto_stock { get; set; }
        string SearchValue { get; set; }


        //eventos
        event EventHandler SearchClienteEvent;
        event EventHandler SearchVendedorEvent;
        //event EventHandler LoadEvent;
        event EventHandler SearchProductoEvent;
        event EventHandler AddNewDetalleEvent;//añade un detalle a la venta
        event EventHandler AddNewEvent;//añade la venta completa
        event EventHandler SaveEvent;
        event EventHandler DeleteEvent; //Eliminar un detalle de la venta
        event EventHandler CancelAllEvent; //limpiar todos los campos de la venta
        event EventHandler CalculateSubtotalEvent; //calcula el subtotal del producto segun la cantidad
        event EventHandler ClearClienteEvent; //limpia los datos del cliente
        event EventHandler ClearProductoEvent;


        //metodos
        //enlace a los detalles de la venta
        void SetVentaDetalleListBindingSource(object ventaDetalleList);
        void Show();

    }
}
