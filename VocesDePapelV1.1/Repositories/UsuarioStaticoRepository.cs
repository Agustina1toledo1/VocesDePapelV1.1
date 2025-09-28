using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Servicios;

namespace VocesDePapelV1._1.Repositories
{
    public class UsuarioStaticoRepository : IUsuarioRepository
    {
        private List<UsuarioModel> usuarios;

        public UsuarioStaticoRepository()
        {
            var hasher = new pbkdf2ContraseniaHasher();

            usuarios = new List<UsuarioModel>
        {
            new UsuarioModel {
                Id_usuario = 1,
                Nombre = "Ana",
                Apellido = "González",
                Cuit_usuario = "20123456789",
                Contraseña = hasher.Hash("clave123"),
                Baja = 0,
                Id_rol = 1,
                Nombre_rol = "Gerente",
                Nombre_estado = "Activo"
            },
            new UsuarioModel {
                Id_usuario = 2,
                Nombre = "Luis",
                Apellido = "Martínez",
                Cuit_usuario = "20234567890",
                Contraseña = hasher.Hash("admin456"),
                Baja = 0,
                Id_rol = 2,
                Nombre_rol = "Administrador",
                Nombre_estado = "Activo"
            },
            new UsuarioModel {
                Id_usuario = 3,
                Nombre = "Sofía",
                Apellido = "Pérez",
                Cuit_usuario = "20345678901",
                Contraseña = hasher.Hash("venta789"),
                Baja = 0,
                Id_rol = 3,
                Nombre_rol = "Vendedor",
                Nombre_estado = "Activo"
            }
        };
        }

        public UsuarioModel ObtenerPorCuit(string cuit)
        {
            return usuarios.FirstOrDefault(u => u.Cuit_usuario == cuit);
        }

        public IEnumerable<RolModel> GetRol() => new List<RolModel>
    {
        new RolModel { Id_rol = 1, Nombre_rol = "Gerente" },
        new RolModel { Id_rol = 2, Nombre_rol = "Administrador" },
        new RolModel { Id_rol = 3, Nombre_rol = "Vendedor" }
    };

        public IEnumerable<EstadoModel> GetEstado() => new List<EstadoModel>
    {
        new EstadoModel { Id_estado = 0, Nombre_estado = "Activo" },
        new EstadoModel { Id_estado = 1, Nombre_estado = "Eliminado" }
    };

        // Métodos no implementados para este caso
        public void Add(UsuarioModel usuario) => throw new NotImplementedException();
        public void Modificar(UsuarioModel usuario) => throw new NotImplementedException();
        public void Eliminar(int id) => throw new NotImplementedException();
        public IEnumerable<UsuarioModel> GetAll() => usuarios;
        public IEnumerable<UsuarioModel> GetByValue(string value) =>
            usuarios.Where(u => u.Nombre.Contains(value) || u.Apellido.Contains(value) || u.Cuit_usuario.Contains(value));
    }

}
