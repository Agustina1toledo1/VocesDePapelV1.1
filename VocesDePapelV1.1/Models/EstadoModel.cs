using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocesDePapelV1._1.Models
{
    public class EstadoModel
    {
        private int id_estado;
        private string nombre_estado;
        public int Id_estado
        {
            get { return id_estado; }
            set { id_estado = value; }
        }
        public string Nombre_estado
        {
            get { return nombre_estado; }
            set { nombre_estado = value; }
        }
    }
}
