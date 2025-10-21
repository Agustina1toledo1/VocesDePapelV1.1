using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Repositories
{
    public class ReporteLibroStockRepository : BaseRepository, IReporteLibroStockRepository
    {
        public ReporteLibroStockRepository(string connectioString)
        {
            this.connectionString = connectioString;
        }
        public IEnumerable<ProductoModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductoModel> GetByValue(string value)
        {
            throw new NotImplementedException();
        }
    }
}
