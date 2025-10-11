using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Repositories
{
    public class AutorRepository: BaseRepository,  IAutorRepository
    {
        //constructor que recibe la cadena de conexion y la pasa a la clase base
        public AutorRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(AutorModel autor)
        {
            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();

                // Verifico existencia del nombre
                command.CommandText = @"
                                    SELECT COUNT(1)
                                        FROM dbo.autor
                                        WHERE alias_autor = @alias_autor;                                     
                                        ";
                command.Parameters.Add("@alias_autor", SqlDbType.NVarChar).Value = autor.Alias_autor;

                int existe = (int)command.ExecuteScalar();
                if (existe > 0)
                {
                    // Retiro los parámetros previos y lanzo excepción de negocio
                    command.Parameters.Clear();
                    throw new InvalidOperationException("El autor ingresado ya está registrado.");
                }

                // Si no existe, hago el INSERT
                command.Parameters.Clear();
                command.CommandText = @"
                    INSERT INTO dbo.autor
                            VALUES
                            (@alias_autor, @id_estado);
                    ";
                command.Parameters.Add("@nombre_categoria", SqlDbType.NVarChar).Value = autor.Alias_autor;
                command.Parameters.Add("@id_estado", SqlDbType.Int).Value = autor.Estado_id;

                command.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var command = new Microsoft.Data.SqlClient.SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "UPDATE autor SET id_estado =1 WHERE id_autor = @id"; //modificamos el estado a 1 (baja logica)
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery(); //ejecuta la consulta

            }
        }

        public IEnumerable<AutorModel> GetAll()
        {
            //lista de autores
            var autorList = new List<AutorModel>();
            //consultas sql
            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var command = new Microsoft.Data.SqlClient.SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT id_autor, alias_autor, id_estado  FROM autor ORDER BY id_autor DESC";
                using (var reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        var autor = new AutorModel
                        {
                            Id_autor = Convert.ToInt32(reader["id_autor"]),
                            Alias_autor = reader["alias_autor"].ToString(),
                            Estado_id = Convert.ToInt32(reader["id_estado"])
                        };
                        autorList.Add(autor);
                    }

                }
            }
            return autorList;
        }

        public IEnumerable<AutorModel> GetByValue(string value)
        {
            //lista de usuarios
            var autorList = new List<AutorModel>();
            string autor_alias = value;
            //consultas sql
            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var command = new Microsoft.Data.SqlClient.SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM autor
                                    WHERE alias_autor like @alias+'%' 
                                    ORDER BY id_autor DESC";

                command.Parameters.Add("@alias", SqlDbType.NVarChar).Value = autor_alias;

                using (var reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        var usuario = new AutorModel
                        {
                            Id_autor = Convert.ToInt32(reader["id_autor"]),
                            Alias_autor = reader["alias_autor"].ToString(),
                            Estado_id = Convert.ToInt32(reader["id_estado"])
                        };
                        autorList.Add(usuario);
                    }

                }
            }
            return autorList;
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

        public void Modificar(AutorModel autor)
        {
            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString)) 
            using (var command = new Microsoft.Data.SqlClient.SqlCommand()) 
            {
                connection.Open();
                command.Connection = connection;

                //consulta sql
                var sql_consulta = new StringBuilder();
                sql_consulta.Append("UPDATE autor SET ");
                sql_consulta.Append("alias_autor = @alias_autor, ");
                sql_consulta.Append("id_estado = @id_estado ");
                sql_consulta.Append("WHERE id_autor = @id_autor");

                command.CommandText = sql_consulta.ToString();
                command.Parameters.Add("@alias_autor", SqlDbType.NVarChar).Value = autor.Alias_autor;
                command.Parameters.Add("@id_estado", SqlDbType.Int).Value = autor.Estado_id;
                command.Parameters.Add("@id_autor", SqlDbType.Int).Value = autor.Id_autor;

                command.ExecuteNonQuery();
            }
        }
    }
}
