using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Repositories
{
    public interface IVentaCabeceraRepository2
    {
        void Add(VentaCabeceraModel2 ventaCabecera);
        void Eliminar(int id);
        IEnumerable<VentaCabeceraModel2> GetById(int value);
        IEnumerable<VentaCabeceraModel2> GetAll();
        IEnumerable<VentaCabeceraModel2> GetByDate(DateTime inicio, DateTime final);
        IEnumerable<VentaCabeceraModel2> GetByVendedorDate(int value, DateTime inicio, DateTime final);

    }
}
