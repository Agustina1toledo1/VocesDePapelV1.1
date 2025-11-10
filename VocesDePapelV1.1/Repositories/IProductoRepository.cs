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
        public (string Categoria, int TotalVendidos) GetCategoriaMasVendida(DateTime fechaInicio, DateTime fechaFin);
        public decimal GetTotalRecaudado(DateTime fechaInicio, DateTime fechaFin);
        IEnumerable<ProductoModel> GetAll(); //listar todos
        IEnumerable<ProductoModel> GetByValueCategoria(string value); //buscar por valor de categoria
        IEnumerable<ProductoModel> GetByValueTitulo(string value); //buscar por valor de titulo
        IEnumerable<ProductoModel> GetByStockMenorOIgual(int value); //buscar por valor de titulo
        IEnumerable<ProductoModel> GetMasVendidos(DateTime fechaInicio, DateTime fechaFin, int cantidad);
        IEnumerable<CategoriaModel> GetCategoria();
        IEnumerable<EstadoModel> GetEstado();
        IEnumerable<AutorModel> GetAutor();
        void ActualizarStock(int idProducto, int cantidad);

    }
}
