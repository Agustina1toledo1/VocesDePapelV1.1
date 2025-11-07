using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Repositories
{
    public interface IVentaDetalleRepository2
    {
        void Add(VentaDetalleModel2 ventaDetalle);
        IEnumerable<VentaDetalleModel2> GetByVentaId(int ventaId);
        IEnumerable<VentaDetalleModel2> GetAll();
        void EliminarPorVentaId(int ventaId);
    }
}
