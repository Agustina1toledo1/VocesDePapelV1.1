using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Repositories
{
    public interface IAutorRepository
    {
        void Add(AutorModel autor);
        void Modificar(AutorModel autor);
        void Eliminar(int id);
        IEnumerable<AutorModel> GetAll(); //listar todos
        IEnumerable<AutorModel> GetByValue(string value); //buscar por valor
        IEnumerable<EstadoModel> GetEstado();
    }
}
