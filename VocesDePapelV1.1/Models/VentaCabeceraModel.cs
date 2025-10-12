using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocesDePapelV1._1.Models
{
    public class VentaCabeceraModel
    {
        private int id_venta_cabecera;
        private DateTime fecha_hora;
        private decimal total_venta;
        private string id_cliente;
        private int id_usuario;
        private int id_estado;

        [DisplayName("N° Factura")]
        public int Id_venta_cabecera
        {
            get { return id_venta_cabecera; }
            set { id_venta_cabecera = value; }
        }

        [DisplayName("Fecha_hora")]
        public DateTime Fecha_hora
        {
            get { return fecha_hora; }
            set { fecha_hora = value; }
        }

        [DisplayName("Total_venta")]
        public decimal Total_venta
        {
            get { return total_venta; }
            set { total_venta = value; }
        }

        [DisplayName("Cliente")]
        public string Id_cliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }

        [DisplayName("ID Vendedor")]
        public int Id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }

       [DisplayName("Estado Venta")]
        public int Id_estado
        {
            get { return id_estado; }
            set { id_estado = value; }
        }

        // Propiedades adicionales para mostrar información relacionada
        [DisplayName("Cliente")]
        public string NombreCliente { get; set; }

        [DisplayName("Vendedor")]
        public string NombreVendedor { get; set; }

        [DisplayName("Estado")]
        public string NombreEstado { get; set; }
    }

}
