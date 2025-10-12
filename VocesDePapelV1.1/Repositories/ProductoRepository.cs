using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Repositories
{
    public class ProductoRepository :BaseRepository, IProductoRepository
    {
        public ProductoRepository(string connectionString) 
        {
            this.connectionString = connectionString;
        }
        public void Add(ProductoModel producto)
        {
            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                // Verifico existencia del producto por su título
                command.CommandText = @"
                                    SELECT COUNT(1)
                                        FROM libro
                                        WHERE titulo = @titulo;
                                        ";
                command.Parameters.Add("@titulo", SqlDbType.NVarChar).Value = producto.Titulo;

                int existe = (int)command.ExecuteScalar();
                if (existe > 0)
                {
                    // Retiro los parámetros previos y lanzo excepción
                    command.Parameters.Clear();
                    throw new InvalidOperationException("El producto ingresado ya está registrado.");
                }
                // Inserto el nuevo producto
                command.Parameters.Clear();
                command.CommandText = @"INSERT INTO libro (titulo, editorial, precio, stock,eliminado, id_categoria) 
                                      VALUES (@titulo, @editorial, @precio,@stock,  @estado,@categoria)";
                command.Parameters.Add("@titulo", SqlDbType.NVarChar).Value= producto.Titulo;
                command.Parameters.Add("@editorial", SqlDbType.NVarChar).Value= producto.Editorial;
                command.Parameters.Add("@stock", SqlDbType.Int).Value= producto.Stock;
                command.Parameters.Add("@precio", SqlDbType.Decimal).Value= producto.Precio;
                command.Parameters.Add("@estado", SqlDbType.Int).Value= producto.Eliminado_id;
                command.Parameters.Add("@categoria", SqlDbType.Int).Value= producto.Id_categoria;
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
                command.CommandText = @"UPDATE libro SET eliminado = 1 WHERE id_libro = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProductoModel> GetAll()
        {
            var productoList = new List<ProductoModel>();

            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString)) 
            using (var command = new Microsoft.Data.SqlClient.SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT id_libro, titulo, editorial, precio, stock, 
                                        eliminado, id_categoria FROM libro 
                                           ORDER BY id_libro DESC";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var producto = new ProductoModel
                        {
                            Id_libro = Convert.ToInt32(reader["id_libro"]),
                            Titulo = reader["titulo"].ToString(),
                            Editorial = reader["editorial"].ToString(),
                            Precio = Convert.ToSingle(reader["precio"]),
                            Stock = Convert.ToInt32(reader["stock"]),
                            Eliminado_id = Convert.ToInt32(reader["eliminado"]),
                            Id_categoria = Convert.ToInt32(reader["id_categoria"])
                        };
                        productoList.Add(producto);
                    }
                }
            }
            return productoList;
        }

        public IEnumerable<ProductoModel> GetByValueCategoria(string value)
        {
            var productoList = new List<ProductoModel>();
            string categoria = value;

            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var command = new Microsoft.Data.SqlClient.SqlCommand())
            {
                connection.Open();
                command.Connection = connection; 
                command.CommandText = @"SELECT libro.id_libro, libro.titulo, libro.editorial, libro.precio, libro.stock, 
                                        libro.eliminado, libro.id_categoria 
                                        FROM libro 
                                        JOIN categoria ON libro.id_categoria = categoria.id_categoria
                                        WHERE  categoria.nombre_categoria LIKE @categoria+'%'
                                        ORDER BY libro.id_libro DESC";

                command.Parameters.Add("@categoria", SqlDbType.NVarChar).Value = categoria;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var producto = new ProductoModel
                        {
                            Id_libro = Convert.ToInt32(reader["id_libro"]),
                            Titulo = reader["titulo"].ToString(),
                            Editorial = reader["editorial"].ToString(),
                            Precio = Convert.ToSingle(reader["precio"]),
                            Stock = Convert.ToInt32(reader["stock"]),
                            Eliminado_id = Convert.ToInt32(reader["eliminado"]),
                            Id_categoria = Convert.ToInt32(reader["id_categoria"])
                        };
                        productoList.Add(producto);
                    }
                }
            }
           return productoList;
        }

        public IEnumerable<ProductoModel> GetByValueTitulo(string value)
        {
            //lista de usuarios
            var productoList = new List<ProductoModel>();

            string titulo = value;
            //consultas sql
            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var command = new Microsoft.Data.SqlClient.SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                //command.CommandText = "SELECT * FROM Usuario ORDER BY id_usuario DESC"; video
                command.CommandText = @"SELECT id_libro, titulo, editorial, precio, stock, 
                                        eliminado, id_categoria  FROM libro
                                    WHERE titulo like @titulo+'%' 
                                    ORDER BY id_libro DESC";

                command.Parameters.Add("@titulo", SqlDbType.NVarChar).Value = titulo;

                using (var reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        var producto = new ProductoModel
                        {
                            Id_libro = Convert.ToInt32(reader["id_libro"]),
                            Titulo = reader["titulo"].ToString(),
                            Editorial = reader["editorial"].ToString(),
                            Precio = Convert.ToSingle(reader["precio"]),
                            Stock = Convert.ToInt32(reader["stock"]),
                            Eliminado_id = Convert.ToInt32(reader["eliminado"]),
                            Id_categoria = Convert.ToInt32(reader["id_categoria"])
                        };
                        productoList.Add(producto);
                    }

                }
            }
            return productoList; 
        }

        public IEnumerable<CategoriaModel> GetCategoria()
        {
            var categoriaList = new List<CategoriaModel>();

            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var command = new Microsoft.Data.SqlClient.SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT id_categoria, nombre_categoria, id_estado
                                        FROM categoria 
                                        ORDER BY id_categoria DESC";
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

        public void Modificar(ProductoModel producto)
        {
            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            //using (var command = connection.CreateCommand())
            using (var command = new Microsoft.Data.SqlClient.SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                
                command.CommandText = @"UPDATE libro SET titulo =@titulo,
                                        editorial =@editorial,
                                        precio=@precio,
                                        stock=@stock,
                                        eliminado =@estado,
                                        id_categoria =@categoria
                                        WHERE id_libro = @id_libro";

                command.Parameters.Add("@id_libro", SqlDbType.Int).Value = producto.Id_libro;
                command.Parameters.Add("@titulo", SqlDbType.NVarChar).Value = producto.Titulo;
                command.Parameters.Add("@editorial", SqlDbType.NVarChar).Value = producto.Editorial;
                command.Parameters.Add("@stock", SqlDbType.Int).Value = producto.Stock;
                command.Parameters.Add("@precio", SqlDbType.Decimal).Value = producto.Precio;
                command.Parameters.Add("@estado", SqlDbType.Int).Value = producto.Eliminado_id;
                command.Parameters.Add("@categoria", SqlDbType.Int).Value = producto.Id_categoria;
                command.ExecuteNonQuery();
            }
        }
    }
}
