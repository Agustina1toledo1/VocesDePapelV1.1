using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Repositories
{
    public interface ICategoriaRepository
    {
        void Add(CategoriaModel usuario);
        void Modificar(CategoriaModel usuario);
        void Eliminar(int id);
        IEnumerable<CategoriaModel> GetAll(); //listar todos
        IEnumerable<CategoriaModel> GetByValue(string value); //buscar por valor
        IEnumerable<EstadoModel> GetEstado();
    }
}
