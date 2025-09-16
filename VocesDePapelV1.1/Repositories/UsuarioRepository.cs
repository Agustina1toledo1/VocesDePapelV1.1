using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;
using VocesDePapelV1._1.Models;
using System.Transactions;

namespace VocesDePapelV1._1.Repositories
{
    public class UsuarioRepository : BaseRepository, IUsuarioRepository
    {

        //constructor que recibe la cadena de conexion y la pasa a la clase base
        public UsuarioRepository(string connectionString)
        {
            this.connectionString = connectionString;
        
        }
        //metodos
        public void Add(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsuarioModel> GetAll()
        {
            //lista de usuarios
            var usuarioList = new List<UsuarioModel>();
            //consultas sql
            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var command = new Microsoft.Data.SqlClient.SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                //command.CommandText = "SELECT * FROM Usuario ORDER BY id_usuario DESC"; video
                command.CommandText = "SELECT id_usuario, nombre, apellido, contraseña, cuit, baja, id_rol FROM Usuario ORDER BY id_usuario DESC";
                using (var reader = command.ExecuteReader())
                //using (var command = new SqlCommand("SELECT id_usuario, nombre, apellido, clave, cuit_usuario, baja, id_rol FROM Usuario", connection))
                {
                    //command.CommandType = CommandType.Text;
                    //using (var reader = command.ExecuteReader())
                    
                        while (reader.Read())
                        {
                            var usuario = new UsuarioModel
                            {
                                Id_usuario = Convert.ToInt32(reader["id_usuario"]),
                                Nombre = reader["nombre"].ToString(),
                                Apellido = reader["apellido"].ToString(),
                                Contraseña = reader["contraseña"].ToString(),
                                Cuit_usuario = Convert.ToInt64(reader["cuit"]), //long
                                Baja = Convert.ToInt16(reader["baja"]), //short
                                Id_rol = Convert.ToInt32(reader["id_rol"])
                            };
                            usuarioList.Add(usuario);
                        }
                    
                }
            }
            return usuarioList;
        }

        public IEnumerable<UsuarioModel> GetByValue(string value)
        {
            //lista de usuarios
            var usuarioList = new List<UsuarioModel>();
            long usuario_cuit = long.TryParse(value, out _) ? Convert.ToInt64(value) : 0; //si es numerico lo convierte, sino 0
            string usuario_nombre_apellido = value;
            //consultas sql
            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var command = new Microsoft.Data.SqlClient.SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                //command.CommandText = "SELECT * FROM Usuario ORDER BY id_usuario DESC"; video
                command.CommandText = @"SELECT *FROM usuario
                                    WHERE cuit = @ciut or nombre like @nombre_apellido+'%' or apellido like @nombre_apellido+'%'
                                    ORDER BY id_usuario DESC";

                command.Parameters.Add("@cuit", SqlDbType.BigInt).Value = usuario_cuit ;
                command.Parameters.Add("@nombre_apellido", SqlDbType.NVarChar).Value = usuario_nombre_apellido;

                using (var reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        var usuario = new UsuarioModel
                        {
                            Id_usuario = Convert.ToInt32(reader["id_usuario"]),
                            Nombre = reader["nombre"].ToString(),
                            Apellido = reader["apellido"].ToString(),
                            Contraseña = reader["contraseña"].ToString(),
                            Cuit_usuario = Convert.ToInt64(reader["cuit"]), //long
                            Baja = Convert.ToInt16(reader["baja"]), //short
                            Id_rol = Convert.ToInt32(reader["id_rol"])
                        };
                        usuarioList.Add(usuario);
                    }

                }
            }
            return usuarioList;
        }

        public void Modificar(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }
    }
}
