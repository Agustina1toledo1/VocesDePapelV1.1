using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocesDePapelV1._1.Models
{
    public class VentaReporteModel
    {
        [DisplayName("N° Factura")]
        public int IdVenta { get; set; }

        [DisplayName("Fecha")]
        public DateTime FechaVenta { get; set; }

        [DisplayName("Cliente")]
        public string NombreCliente { get; set; }

        [DisplayName("Vendedor")]
        public string NombreVendedor { get; set; }

        [DisplayName("Total Venta")]
        public decimal TotalVenta { get; set; }

        [DisplayName("Estado")]
        public string EstadoVenta { get; set; }

        [DisplayName("Cantidad Productos")]
        public int CantidadProductos { get; set; }

       
    }
}
