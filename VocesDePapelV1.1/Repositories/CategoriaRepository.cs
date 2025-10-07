using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Repositories
{
    public class CategoriaRepository : BaseRepository, ICategoriaRepository
    {
        //constructor que recibe la cadena de conexion y la pasa a la clase base
        public CategoriaRepository(string connectionString)
        {
            this.connectionString = connectionString;

        }
        //metodos de la interfaz
        public void Add(CategoriaModel categoria)
        {
            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();

                // Verifico existencia del nombre
                command.CommandText = @"
                                    SELECT COUNT(1)
                                        FROM dbo.categoria
                                        WHERE nombre_categoria = @nombre_categoria;                                     
                                        ";
                command.Parameters.Add("@nombre_categoria", SqlDbType.NVarChar, 50).Value = categoria.Nombre_categoria;

                int existe = (int)command.ExecuteScalar();
                if (existe > 0)
                {
                    // Retiro los parámetros previos y lanzo excepción de negocio
                    command.Parameters.Clear();
                    throw new InvalidOperationException("El nombre ingresado ya está registrado.");
                }

                // Si no existe, hago el INSERT
                command.Parameters.Clear();
                command.CommandText = @"
                    INSERT INTO dbo.categoria
                            VALUES
                            (@nombre_categoria, @id_estado);
                    ";
                command.Parameters.Add("@nombre_categoria", SqlDbType.NVarChar).Value = categoria.Nombre_categoria;
                command.Parameters.Add("@id_estado", SqlDbType.Int).Value = categoria.Estado_id;

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
                command.CommandText = "UPDATE categoria SET id_estado =1 WHERE id_categoria = @id"; //modificamos el estado a 1 (baja logica)
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery(); //ejecuta la consulta

            }
        }

        public IEnumerable<CategoriaModel> GetAll()
        {
            //lista de categorias
            var categoriaList = new List<CategoriaModel>();
            //consultas sql
            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var command = new Microsoft.Data.SqlClient.SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT id_categoria, nombre_categoria, id_estado  FROM Categoria ORDER BY id_categoria DESC";
                using (var reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        var categoria = new CategoriaModel
                        {
                            Id_categoria = Convert.ToInt32(reader["id_categoria"]),
                            Nombre_categoria = reader["nombre_categoria"].ToString(),
                            Estado_id = Convert.ToInt32(reader["id_estado"])
                        };
                        categoriaList.Add(categoria);
                    }

                }
            }
            return categoriaList;
        }

        public IEnumerable<CategoriaModel> GetByValue(string value)
        {
            //lista de usuarios
            var categoriaList = new List<CategoriaModel>();
            //long usuario_cuit = long.TryParse(value, out _) ? Convert.ToInt64(value) : 0; //si es numerico lo convierte, sino 0
            string categoria_nombre = value;
            //consultas sql
            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var command = new Microsoft.Data.SqlClient.SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                //command.CommandText = "SELECT * FROM Usuario ORDER BY id_usuario DESC"; video
                command.CommandText = @"SELECT *FROM categoria
                                    WHERE nombre_categoria like @nombre+'%' 
                                    ORDER BY id_categoria DESC";

                command.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = categoria_nombre;

                using (var reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        var usuario = new CategoriaModel
                        {
                            Id_categoria = Convert.ToInt32(reader["id_categoria"]),
                            Nombre_categoria = reader["nombre_categoria"].ToString(),
                            Estado_id = Convert.ToInt32(reader["id_estado"])
                        };
                        categoriaList.Add(usuario);
                    }

                }
            }
            return categoriaList;
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

        public void Modificar(CategoriaModel categoria)
        {
            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var command = new Microsoft.Data.SqlClient.SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                // consulta sql
                var sql_consulta = new StringBuilder();
                sql_consulta.Append("UPDATE categoria SET ");
                sql_consulta.Append("nombre_categoria = @nombre_categoria, ");
                sql_consulta.Append("id_estado = @id_estado");

               
                sql_consulta.Append(" WHERE id_categoria = @id_categoria");

                command.CommandText = sql_consulta.ToString();

                command.Parameters.Add("@id_categoria", SqlDbType.Int).Value = categoria.Id_categoria;
                command.Parameters.Add("@nombre_categoria", SqlDbType.NVarChar).Value = categoria.Nombre_categoria;
                command.Parameters.Add("@id_estado", SqlDbType.Int).Value = categoria.Estado_id;
                command.ExecuteNonQuery(); //ejecuta la consulta


            }
        }
    }
}
