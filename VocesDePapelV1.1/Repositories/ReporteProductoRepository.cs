using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Repositories
{
    public class ReporteProductoRepository : BaseRepository, IReporteProductoRepository
    {
        public ReporteProductoRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void ObtenerLibrosConStockMenorOIgual(int stockMinimo)
        {
            var productoFiltradoList = new List<ProductoModel>();
            int stock = stockMinimo;

        }
    }
}
