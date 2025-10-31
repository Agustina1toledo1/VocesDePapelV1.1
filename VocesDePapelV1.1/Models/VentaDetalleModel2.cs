using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocesDePapelV1._1.Models
{
    public class VentaDetalleModel2
    {
        private int id_venta_detalle;
        private int cantidad;
        private decimal precio_unitario;
        private int id_venta_cabecera;
        private int id_libro;
        private decimal subtotal;


        [DisplayName("ID Detalle Venta")]
        public int Id_venta_detalle
        {
            get { return id_libro; }
            set { id_libro = value; }
        }

        [DisplayName("Cantidad")]
        [Required(ErrorMessage = "La cantidad es requerida")]
        [Range(1, 1000, ErrorMessage = "La cantidad debe estar entre 1 y 1000 unidades")]
        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                if (value < 1)
                    throw new ArgumentException("La cantidad debe ser al menos 1");
                if (value > 1000)
                    throw new ArgumentException("La cantidad no puede exceder 1000 unidades");
                cantidad = value;
            }
        }

        [DisplayName("Precio Unitario")]
        [Required(ErrorMessage = "El precio unitario es requerido")]
        [Range(0.01, 100000.00, ErrorMessage = "El precio unitario debe estar entre $0.01 y $100,000.00")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "El precio debe tener máximo 2 decimales")]
        public decimal Precio_unitario
        {
            get { return precio_unitario; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El precio unitario debe ser mayor a 0");
                if (value > 100000)
                    throw new ArgumentException("El precio unitario no puede exceder $100,000.00");

                // Validar que solo tenga 2 decimales
                if (Decimal.Round(value, 2) != value)
                    throw new ArgumentException("El precio unitario solo puede tener hasta 2 decimales");

                precio_unitario = value;
            }
        }
        [DisplayName("Subtotal")]
        [Required(ErrorMessage = "El subtotal es requerido")]
        [Range(0.01, 100000.00, ErrorMessage = "El subtotaldebe estar entre $0.01 y $100,000.00")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "El subtotal debe tener máximo 2 decimales")]
        public decimal Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        [DisplayName("ID Venta Cabecera")]
        public int Id_venta_cabecera
        {
            get { return id_venta_cabecera; }
            set { id_venta_cabecera = value; }
        }

        [DisplayName("ID Libro")]
        [Required(ErrorMessage = "El ID del libro es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "El ID del libro debe ser válido")]
        public int Id_libro
        {
            get { return id_libro; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El ID del libro debe ser mayor a 0");
                id_libro = value;
            }
        }

        // Propiedad calculada (solo lectura)
        /*[DisplayName("Subtotal")]
        [Browsable(false)] // No mostrar en DataGridView
        public decimal Subtotal
        {
            get { return Cantidad * Precio_unitario; }
        }*/

        // Propiedades de navegación (para mostrar información relacionada)
        [DisplayName("Título del Libro")]
        public string Titulo_libro { get; set; }

        [DisplayName("Producto")]
        [Browsable(false)]
        public ProductoModel Libro { get; set; }

        // Constructor
        /*public VentaDetalleModel()
        {
            // Valores por defecto
            Cantidad = 1;
            Precio_unitario = 0;
        }

        // Constructor con parámetros
        public VentaDetalleModel(int idLibro, int cantidad, decimal precioUnitario)
        {
            Id_libro = idLibro;
            Cantidad = cantidad;
            Precio_unitario = precioUnitario;
        }

        // Método para validar el modelo manualmente (adicional a DataAnnotations)
        public void Validar()
        {
            // Validar cantidad
            if (Cantidad < 1)
                throw new InvalidOperationException("La cantidad debe ser al menos 1");

            if (Cantidad > 1000)
                throw new InvalidOperationException("La cantidad no puede exceder 1000 unidades");

            // Validar precio
            if (Precio_unitario <= 0)
                throw new InvalidOperationException("El precio unitario debe ser mayor a 0");

            if (Precio_unitario > 100000)
                throw new InvalidOperationException("El precio unitario no puede exceder $100,000.00");

            // Validar IDs
            if (Id_venta_cabecera <= 0 && Id_venta_cabecera != 0) // Permitir 0 para ventas nuevas
                throw new InvalidOperationException("El ID de venta cabecera debe ser válido");

            if (Id_libro <= 0)
                throw new InvalidOperationException("El ID del libro debe ser válido");

            // Validar que el precio solo tenga 2 decimales
            if (Decimal.Round(Precio_unitario, 2) != Precio_unitario)
                throw new InvalidOperationException("El precio unitario solo puede tener hasta 2 decimales");
        }

        // Método para clonar el detalle
        public VentaDetalleModel Clonar()
        {
            return new VentaDetalleModel
            {
                Id_venta_detalle = this.Id_venta_detalle,
                Cantidad = this.Cantidad,
                Precio_unitario = this.Precio_unitario,
                Id_venta_cabecera = this.Id_venta_cabecera,
                Id_libro = this.Id_libro,
                Titulo_libro = this.Titulo_libro
            };
        }

        // Override de ToString para debugging
        public override string ToString()
        {
            return $"Detalle: {Titulo_libro ?? "Libro"} x {Cantidad} = ${Subtotal:F2}";
        }*/
    }

}

