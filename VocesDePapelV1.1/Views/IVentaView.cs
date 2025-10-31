using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VocesDePapelV1._1.Models;
namespace VocesDePapelV1._1.Views
{
    public interface IVentaView
    {
        // eventos para las acciones del usuario
        event EventHandler AddNewClienteEvent;
        event EventHandler EditarClienteEvent;
        event EventHandler SearchClienteByCuitEvent;
        event EventHandler ClearClienteEvent;
        // eventos para las acciones del vendedor
        event EventHandler SearchVendedorByCuitEvent;
        // eventos para las acciones de la venta
        event EventHandler FinalizarVentaEvent;
        event EventHandler CancelarVentaEvent;
        event EventHandler AgregarProductoEvent;
        event EventHandler BuscarProductoEvent;
        event EventHandler EliminarProductoEvent;
        event EventHandler SearchEvent;
        event EventHandler VerDetallesEvent;
        event EventHandler AnularVentaEvent;
        event EventHandler CantidadCambiadaEvent;
        event EventHandler PrecioCambiadoEvent;
        // propiedad para el formulario
        Form FormInstance { get; }
        // propiedades para los datos del cliente
        string ClienteCuit { get; set; }
        string ClienteNombre { get; set; }
        string ClienteEmail { get; set; }
        string ClienteTelefono { get; set; }
        // propiedades para los datos del vendedor
        string VendedorCuit { get; set; }
        string VendedorNombre { get; set; }

        // Propiedades para agregar productos
        string TipoBusqueda { get; set; }
        string ProductoBusqueda { get; set; }
        int ProductoSeleccionadoId { get; set; }
        int ProductoCantidad { get; set; }
        decimal ProductoPrecio { get; set; }
        string ProductoSeleccionadoNombre { get; set; }
        string ProductoSeleccionadoCategoria { get; set; }
        string ProductoSeleccionadoPrecio { get; set; }
        string ProductoSeleccionadoStock { get; set; }
        decimal ProductoSeleccionadoSubtotal { get; set; }
        // propiedades para los datos de la venta
        string NumeroFactura { get; set; }
        DateTime FechaVenta { get; set; }
        int IdCliente { get; set; }
        decimal TotalVenta { get; set; }
        // propiedad para los detalles de la venta

        BindingList<VentaDetalleModel> Detalles { get; }
        BindingSource VentaListBindingSource { get; }
        string SearchValue { get; }
        void AgregarDetalle(VentaDetalleModel detalle);
        void EliminarDetalle(int index);
        void LimpiarDetalles();
        void MostrarDetallesVenta(IEnumerable<VentaDetalleModel> detalles);
        void MostrarProductosEncontrados(IEnumerable<ProductoModel> productos);
        void MostrarMensaje(string mensaje, bool esExitoso);
        void Show();
    }
}
