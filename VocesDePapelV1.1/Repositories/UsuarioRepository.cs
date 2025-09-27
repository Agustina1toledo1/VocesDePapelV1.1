using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Models
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
            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();

                // Verifico existencia de CUIT
                command.CommandText = @"
                                    SELECT COUNT(1)
                                        FROM dbo.usuario
                                     WHERE cuit = @cuit;
                                        ";
                command.Parameters.Add("@cuit", SqlDbType.NVarChar, 20).Value = usuario.Cuit_usuario;

                int existe = (int)command.ExecuteScalar();
                if (existe > 0)
                {
                    // Retiro los parámetros previos y lanzo excepción de negocio
                    command.Parameters.Clear();
                    throw new InvalidOperationException("El CUIT ingresado ya está registrado.");
                }

                // Si no existe, hago el INSERT
                command.Parameters.Clear();
                command.CommandText = @"
                    INSERT INTO dbo.usuario
                            (nombre, apellido, contraseña, cuit, baja, id_rol)
                            VALUES
                            (@nombre, @apellido, @contraseña, @cuit, @baja, @id_rol);
                    ";
                command.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = usuario.Nombre;
                command.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = usuario.Apellido;
                command.Parameters.Add("@contraseña", SqlDbType.NVarChar).Value = usuario.Contraseña;
                command.Parameters.Add("@cuit", SqlDbType.NVarChar).Value = usuario.Cuit_usuario;
                command.Parameters.Add("@baja", SqlDbType.Int).Value = usuario.Baja;
                command.Parameters.Add("@id_rol", SqlDbType.Int).Value = usuario.Id_rol;

                command.ExecuteNonQuery();
            }
        }
        public void Eliminar(int id) //cambia de estado a 1 (baja logica)
        {
            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var command = new Microsoft.Data.SqlClient.SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE usuario SET baja =1 WHERE id_usuario = @id"; //modificamos el estado a 1 (baja logica)
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery(); //ejecuta la consulta

            }
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
                {
                    
                        while (reader.Read())
                        {
                            var usuario = new UsuarioModel
                            {
                                Id_usuario = Convert.ToInt32(reader["id_usuario"]),
                                Nombre = reader["nombre"].ToString(),
                                Apellido = reader["apellido"].ToString(),
                                Contraseña = reader["contraseña"].ToString(),
                                Cuit_usuario = reader["cuit"].ToString(), //char(11)
                                Baja = Convert.ToInt32(reader["baja"]), //int
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
            //long usuario_cuit = long.TryParse(value, out _) ? Convert.ToInt64(value) : 0; //si es numerico lo convierte, sino 0
            string usuario_cuit = value;
            string usuario_nombre_apellido = value;
            //consultas sql
            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var command = new Microsoft.Data.SqlClient.SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                //command.CommandText = "SELECT * FROM Usuario ORDER BY id_usuario DESC"; video
                command.CommandText = @"SELECT *FROM usuario
                                    WHERE cuit like @cuit+'%' or nombre like @nombre_apellido+'%' or apellido like @nombre_apellido+'%'
                                    ORDER BY id_usuario DESC";

                command.Parameters.Add("@cuit", SqlDbType.NVarChar).Value = usuario_cuit ;
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
                            Cuit_usuario = reader["cuit"].ToString(), //long
                            Baja = Convert.ToInt16(reader["baja"]), //short
                            Id_rol = Convert.ToInt32(reader["id_rol"])
                        };
                        usuarioList.Add(usuario);
                    }

                }
            }
            return usuarioList;
        }

        public IEnumerable<EstadoModel> GetEstado()
        {
            //lista de estados
            var estadoList = new List<EstadoModel>();
            //consultas sql
            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var command = new Microsoft.Data.SqlClient.SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT *  FROM estado ORDER BY id_estado DESC";
                using (var reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        var estado = new EstadoModel
                        {
                            Id_estado = Convert.ToInt32(reader["id_estado"]),
                            Nombre_estado = reader["nombre_estado"].ToString(),
                        };
                        estadoList.Add(estado);
                    }

                }
            }
            return estadoList;
        }

        public IEnumerable<RolModel> GetRol()
        {
            //lista de usuarios
            var rolList = new List<RolModel>();
            //consultas sql
            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var command = new Microsoft.Data.SqlClient.SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT *  FROM rol ORDER BY id_rol DESC";
                using (var reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        var rol = new RolModel
                        {
                            Id_rol = Convert.ToInt32(reader["id_rol"]),
                            Nombre_rol = reader["nombre_rol"].ToString(),
                        };
                        rolList.Add(rol);
                    }

                }
            }
            return rolList;
        }

        public void Modificar(UsuarioModel usuario)
        {
            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var command = new Microsoft.Data.SqlClient.SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                // consulta sql
                var sql_consulta = new StringBuilder();
                sql_consulta.Append("UPDATE usuario SET ");
                sql_consulta.Append("nombre = @nombre, ");
                sql_consulta.Append("apellido = @apellido, ");
                sql_consulta.Append("cuit = @cuit, ");
                sql_consulta.Append("baja = @baja, ");
                sql_consulta.Append("id_rol = @id_rol");

                // Agregar contraseña solo si no está vacía
                if (usuario.Contraseña != "00000000")
                {
                    sql_consulta.Append(", contraseña = @contraseña");
                    command.Parameters.Add("@contraseña", SqlDbType.NVarChar).Value = usuario.Contraseña;
                }

                sql_consulta.Append(" WHERE id_usuario = @id_usuario");

                command.CommandText = sql_consulta.ToString();

                command.Parameters.Add("@id_usuario", SqlDbType.Int).Value = usuario.Id_usuario;
                command.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = usuario.Nombre;
                command.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = usuario.Apellido;
                command.Parameters.Add("@cuit", SqlDbType.NVarChar).Value = usuario.Cuit_usuario;
                command.Parameters.Add("@baja", SqlDbType.Int).Value = usuario.Baja;
                command.Parameters.Add("@id_rol", SqlDbType.Int).Value = usuario.Id_rol;
                command.ExecuteNonQuery(); //ejecuta la consulta


            }
             
        }

        public UsuarioModel ObtenerPorCuit(string cuit)
        {
            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var command = new Microsoft.Data.SqlClient.SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"
            SELECT u.*, r.nombre_rol as Nombre_rol, 
                   CASE WHEN u.baja = 0 THEN 'Activo' ELSE 'Inactivo' END as Nombre_estado
            FROM usuario u 
            INNER JOIN rol r ON u.id_rol = r.id_rol 
            WHERE u.cuit = @cuit";

                command.Parameters.Add("@cuit", SqlDbType.NVarChar).Value = cuit;

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var usuario = new UsuarioModel
                        {
                            Id_usuario = (int)reader["id_usuario"],
                            Nombre = reader["nombre"].ToString(),
                            Apellido = reader["apellido"].ToString(),
                            Contraseña = reader["contraseña"].ToString(), // ← Este es el HASH
                            Cuit_usuario = reader["cuit"].ToString(),
                            Baja = (int)reader["baja"],
                            Id_rol = (int)reader["id_rol"],
                            Nombre_rol = reader["nombre_rol"]?.ToString(),
                            Nombre_estado = reader["Nombre_estado"]?.ToString()
                        };
                        return usuario;
                    }
                }
            }
            return null;
        }
    }
}
