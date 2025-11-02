using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Repositories
{
    public class VentaDetalleRepository2 : BaseRepository, IVentaDetalleRepository2
    {
        public VentaDetalleRepository2(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(VentaDetalleModel2 ventaDetalle)
        {
            throw new NotImplementedException();
        }

        public void EliminarPorVentaId(int ventaId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VentaDetalleModel2> GetByVentaId(int ventaId)
        {
            throw new NotImplementedException();
        }
    }
}
