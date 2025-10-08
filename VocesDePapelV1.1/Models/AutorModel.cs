using System;
using System.Collections.Generic;
using System.ComponentModel;//display
using System.ComponentModel.DataAnnotations; //required
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocesDePapelV1._1.Models
{
    public class AutorModel
    {
        //campos
        private int id_autor;
        private string alias_autor;
        private int id_estado;

        //accesors y mutators. Validaciones
        [DisplayName("Autor_id")]
        public int Id_autor
        {
            get { return id_autor; }
            set { id_autor = value; }
        }
        [DisplayName("Alias del autor")]
        [Required(ErrorMessage = "El alias del autor es requerido")]
        [RegularExpression(@"^[\p{L}\s]{3,100}$", ErrorMessage = "El nombre debe contener solo letras y espacios, entre 3 y 100 caracteres.")]
        public string Alias_autor
        {
            get { return alias_autor; }
            set { alias_autor = value; }
        }
        [DisplayName("Estado id")]
        [Required(ErrorMessage = "El estado del usuario es requerido")]
        public int Estado_id
        {
            get { return id_estado; }
            set { id_estado = value; }
        }
        [DisplayName("Estado nombre ")]
        public string Nombre_estado { get; set; }
    }
}
