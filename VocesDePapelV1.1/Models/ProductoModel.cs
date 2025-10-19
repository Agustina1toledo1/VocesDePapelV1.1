using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VocesDePapelV1._1.Models
{
    public class ProductoModel
    {
        private int id_libro;
        private string titulo;
        private string editorial;
        private decimal precio;
        private int stock;
        private int eliminado;
        private int id_categoria;
        private int id_autor;

        //accesors y mutators. Validaciones
        [DisplayName("ID Libro")]
        public int Id_libro
        {
            get { return id_libro; }
            set { id_libro = value; }
        }

        [DisplayName("Titulo Libro")]
        [Required(ErrorMessage = "El nombre de usuario es requerido")]
        [RegularExpression(@"^.{3,50}$", ErrorMessage = "El título solo debe tener entre 3 y 50 caracteres.")]

        public string Titulo { 
            get { return titulo; } 
            set { titulo = value; } 
        }
        [DisplayName("Editorial")]
        [Required(ErrorMessage = "La editorial es requerido")]
        public string Editorial { 
            get { return editorial; } 
            set { editorial = value; }
        }
        [DisplayName("Precio")]
        [Required(ErrorMessage = "El precio es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe ingresar un número mayor a 0.")]

        public decimal Precio { 
            get { return precio; } 
            set { precio = value; }
        }
        [DisplayName("Stock")]
        [Required(ErrorMessage = "El stock es requerido")]
        [RegularExpression(@"^[1-9][0-9]*$", ErrorMessage = "Debe ingresar un Stock entero mayor a 0.")]

        public int Stock { 
            get { return stock; } 
            set { stock = value; }
        }
        [DisplayName("Eliminado_id")]
        [Required(ErrorMessage = "El estado es requerido")]
        public int Eliminado_id { 
            get { return eliminado; }
            set { eliminado = value; }
        }
        [DisplayName("Id categoria")]
        [Required(ErrorMessage = "La categoria es requerido")]
        public int Id_categoria { 
            get { return id_categoria; } 
            set { id_categoria = value; }
        }
        public int Id_autor { 
            get { return id_autor; } 
            set { id_autor = value; }
        }
        //propiedades adicionales para mostrar el nombre del estado y rol en la vista
        [DisplayName("Nombre estado ")] //se asocia al nombre del encabezado de la columna en el datagridview
        public string Nombre_estado { get; set; }

        [DisplayName("Nombre categoria ")]
        public string Nombre_categoria { get; set; }

        [DisplayName("Nombre autor ")]
        public string Nombre_autor { get; set; }
    }
}
