using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Repositories
{
    public interface IVentaDetalleRepository
    {
        void Add(VentaDetalleModel ventaDetalle);
        void AddRange(IEnumerable<VentaDetalleModel> detalles);
        IEnumerable<VentaDetalleModel> GetByVentaId(int ventaId);
        void EliminarPorVentaId(int ventaId);
    }
}
