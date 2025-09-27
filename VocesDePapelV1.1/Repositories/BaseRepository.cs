using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocesDePapelV1._1.Repositories
{
    public abstract class BaseRepository
    {
        protected string connectionString; //cadena de conexion protegida
        //constructor que recibe la cadena de conexion
        public BaseRepository(string connectionString)
        {
           this.connectionString = connectionString;
        }
    }
}
