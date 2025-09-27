using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Servicios
{
    public class AuthService : IAuthService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IContraseniaHasher _contraseniaHasher;

        public AuthService(IUsuarioRepository usuarioRepository, IContraseniaHasher contraseniaHasher)
        {
            _usuarioRepository = usuarioRepository;
            _contraseniaHasher = contraseniaHasher;
        }

        public UsuarioModel Autenticar(string cuit, string contrasenia)
        {
            if (string.IsNullOrWhiteSpace(cuit) || string.IsNullOrWhiteSpace(contrasenia))
                return null;

            // Buscar usuario por CUIT
            var usuario = _usuarioRepository.ObtenerPorCuit(cuit);

            if (usuario == null || usuario.Baja == 1) // 1 = inactivo
                return null;

            // Verificar contraseña (compara el hash)
            bool contraseniaValida = _contraseniaHasher.Verify(contrasenia, usuario.Contraseña);

            return contraseniaValida ? usuario : null;
        }

        public bool UsuarioEstaActivo(UsuarioModel usuario)
        {
            return usuario.Baja == 0; // 0 = activo, 1 = inactivo
        }
    }
}
