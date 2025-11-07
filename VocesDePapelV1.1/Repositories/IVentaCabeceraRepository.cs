using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Repositories
{
    public interface IVentaCabeceraRepository
    {
        void Add(VentaCabeceraModel ventaCabecera);
        void Modificar(VentaCabeceraModel ventaCabecera);
        void eliminar(int id); 
        IEnumerable<VentaCabeceraModel> GetAll();
        IEnumerable<VentaCabeceraModel> GetByValue(string value);
        VentaCabeceraModel ObtenerPorId(int id);
        int ObtenerProximoNumeroFactura();
      //  IEnumerable<VentaCabeceraModel2> GetByVendedorDate(int value, DateTime inicio, DateTime final);

    }

}
