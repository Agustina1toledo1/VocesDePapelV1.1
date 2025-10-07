using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Repositories
{
    public interface IClienteRepository
    {
        void Add(ClienteModel cliente);
        void Modificar(ClienteModel cliente);
        void Eliminar(int id);
        IEnumerable<ClienteModel> GetAll();
        IEnumerable<ClienteModel> GetByValue(string value);
    }
}
