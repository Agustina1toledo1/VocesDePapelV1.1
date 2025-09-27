using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocesDePapelV1._1.Repositories
{
    public class RolModel
    {
        private int id_rol;
        private string nombre_rol;

        public int Id_rol
        {
            
            get { return id_rol; }
            set { id_rol = value; }
             
        }
        public string Nombre_rol {
            get { return nombre_rol; }
            set { nombre_rol = value; } 
        }
    }
}
