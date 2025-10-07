using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocesDePapelV1._1.Models
{
    public class ClienteModel
    {
        private int id_cliente;
        private string nombre_razonSocial;
        private string cuit_cuil;
        private string telefono;
        private string email;


        [DisplayName("ID Cliente")]
        public int Id_cliente { 
            get{ return id_cliente;}
            set { id_cliente = value;} 
        }

        [DisplayName("Nombre o Razón Social")]
        [Required(ErrorMessage = "El nombre o razón social es obligatorio")]
        public string Nombre_razonSocial {
            get { return nombre_razonSocial;}

            set{ nombre_razonSocial = value;} 
        }

        [DisplayName("CUIT/CUIL")]
        [Required(ErrorMessage = "El CUIT/CUIL es obligatorio")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Debe tener 11 dígitos")]
        public string Cuit_cuil {
            get { return cuit_cuil;}
            set { cuit_cuil = value;} 
        }

        [DisplayName("Teléfono")]
        public string Telefono {
            get{ return telefono;}
            set { telefono = value;} 
        }

        [DisplayName("Email")]
        [EmailAddress(ErrorMessage = "Formato de email inválido")]
        public string Email {
            get { return email;}
            set { email = value;} 
        }
        
    }
}
