using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//define comportamiento
namespace VocesDePapelV1._1.Models
{
    public interface IUsuarioRepository
    {
        void Add(UsuarioModel usuario);
        void Modificar(UsuarioModel usuario);
        void Eliminar(UsuarioModel usuario);
        IEnumerable<UsuarioModel> GetAll(); //listar todos
        IEnumerable<UsuarioModel> GetByValue(string value); //buscar por valor
    }
}
