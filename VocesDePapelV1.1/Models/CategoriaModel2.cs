using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocesDePapelV1._1.Models
{
    internal class CategoriaModel2
    {
        //campos de la tabla Categoria
        private int id_categoria;
        private string nombre_categoria;
        private int id_estado;

        //accesors y mutators. Validaciones
        [DisplayName("Categoria_id")]
        public int Id_categoria
        {
            get { return id_categoria; }
            set { id_categoria = value; }
        }
        [DisplayName("Nombre")]
        [Required(ErrorMessage = "El nombre de la categoria es requerido")]
        [RegularExpression(@"^[\p{L}\s]{3,50}$", ErrorMessage = "El nombre debe contener solo letras y espacios, entre 3 y 50 caracteres.")]

        public string Nombre_categoria
        {
            get { return nombre_categoria; }
            set { nombre_categoria = value; }
        }

        [DisplayName("Estado_id")]
        [Required(ErrorMessage = "El estado del usuario es requerido")]
        public int Estado_id
        {
            get { return id_estado; }
            set { id_estado = value; }
        }

        [DisplayName("Estado nombre ")] //se asocia al nombre del encabezado de la columna en el datagridview
        public string Nombre_estado { get; set; }
    }
}
