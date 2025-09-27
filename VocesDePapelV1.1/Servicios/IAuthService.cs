using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Servicios
{
    public interface IAuthService
    {
        UsuarioModel Autenticar(string cuit, string contrasenia);
        bool UsuarioEstaActivo(UsuarioModel usuario);
    }
}
