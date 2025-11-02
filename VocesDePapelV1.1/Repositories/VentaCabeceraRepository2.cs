using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Repositories
{
    public class VentaCabeceraRepository2 : BaseRepository, IVentaCabeceraRepository2
    {
        public VentaCabeceraRepository2(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(VentaCabeceraModel2 ventaCabecera)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VentaCabeceraModel2> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VentaCabeceraModel2> GetByDate(DateTime inicio, DateTime final)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VentaCabeceraModel2> GetById(int value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VentaCabeceraModel2> GetByVendedorDate(int value, DateTime inicio, DateTime final)
        {
            throw new NotImplementedException();
        }
    }
}
