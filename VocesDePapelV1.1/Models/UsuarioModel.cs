using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace VocesDePapelV1._1.Models
{
    public class UsuarioModel
    {
        //campos de la tabla Usuario
        private int id_usuario;
        private string nombre;
        private string apellido;
        private string clave;
        private long cuit_usuario;
        private short baja;
        private int id_rol;

        //accesors y mutators. Validaciones
        [DisplayName ("Usuario ID")]
        public int Id_usuario 
        { 
            get { return id_usuario; }
            set { id_usuario = value; } 
        }
        [DisplayName("Nombre del usuario")]
        [Required(ErrorMessage = "El nombre de usuario es requerido")]
        [RegularExpression(@"^[a-zA-Z]{3,50}$", ErrorMessage = "Solo se permiten letras y  debe tener entre 3 y 50 caracteres.")]
        public string Nombre 
        { 
            get { return nombre; }
            set { nombre = value; }            
        }
        [DisplayName("Apellido del usuario")]
        [Required(ErrorMessage = "El apellido de usuario es requerido")]
        [RegularExpression(@"^[a-zA-Z]{3,50}$", ErrorMessage = "Solo se permiten letras y  debe tener entre 3 y 50 caracteres.")]
        public string Apellido 
        { 
            get { return apellido; }            
            set { apellido = value; }             
        }
        [DisplayName("Clave del usuario")]
        [Required(ErrorMessage = "La clave del usuario es requerido")]
        [StringLength( 8, ErrorMessage = "La contraseña debe contener al menos 8 caracteres")]
        public string Clave 
        { 
            get { return clave; }  
            set { clave = value; }
        }
        [DisplayName("Cuit del usuario")]
        [Required(ErrorMessage = "El cuiy del usuario es requerido")]
        [StringLength(11, ErrorMessage = "El cuit no puede ser mayor a 11 caracteres")]
        [RegularExpression("(^[0-9]){11}$", ErrorMessage = "Solo se permiten números y debe contener 11 caracteres\"")] //^ indica inicio de la cadena, $ indica fin de la cadena, [0-9] indica que solo se permiten números, + indica que se permiten uno o más caracteres
        public long Cuit_usuario { 
            get { return cuit_usuario; }             
            set { cuit_usuario = value; }             
        }
        [DisplayName("Estado del usuario")]
        [Required(ErrorMessage = "El estado del usuario es requerido")]
        public short Baja 
        { 
            get { return baja; }
            set { baja = value; }
        }
        [DisplayName("Rol del usuario")]
        [Required(ErrorMessage = "El rol del usuario es requerido")]
        public int Id_rol 
        { 
            get { return id_rol; }            
            set { id_rol = value; }            
        }
    }
}
