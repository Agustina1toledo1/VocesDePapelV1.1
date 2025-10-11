using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Repositories
{
    public interface IProductoRepository
    {
        void Add(ProductoModel producto);
        void Modificar(ProductoModel producto);
        void Eliminar(int id);
        IEnumerable<ProductoModel> GetAll(); //listar todos
        IEnumerable<ProductoModel> GetByValue(string value); //buscar por valor
        IEnumerable<CategoriaModel> GetCategoria();
        IEnumerable<EstadoModel> GetEstado();
    }
}
