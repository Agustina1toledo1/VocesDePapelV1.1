using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocesDePapelV1._1.Models
{
    internal class ClienteModel
    {
        private int id_cliente;
        private string nombre_razonSocial;
        private string cuit_cuil;
        private string telefono;
        private string email;
        public int Id_cliente { 
            get{ return id_cliente;}
            set { id_cliente = value;} 
        }
        public string Nombre_razonSocial {
            get { return nombre_razonSocial;}

            set{ nombre_razonSocial = value;} 
        }
        public string Cuit_cuil {
            get { return cuit_cuil;}
            set { cuit_cuil = value;} 
        }
        public string Telefono {
            get{ return telefono;}
            set { telefono = value;} 
        }
        public string Email {
            get { return email;}
            set { email = value;} 
        }
        
    }
}
