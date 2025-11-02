using System.Data;
using System.Data.SqlClient;
using System.Text;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Repositories
{
    public class ProductoRepository : BaseRepository, IProductoRepository
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
                command.CommandText = @"INSERT 
                                            INTO libro 
                                                (titulo, 
                                                editorial, 
                                                precio, 
                                                 stock,
                                                eliminado, 
                                                id_categoria, 
                                                id_autor) 
                                      VALUES (@titulo, @editorial, @precio,@stock,  @estado,@categoria, @autor);";
                command.Parameters.Add("@titulo", SqlDbType.NVarChar).Value = producto.Titulo;
                command.Parameters.Add("@editorial", SqlDbType.NVarChar).Value = producto.Editorial;
                command.Parameters.Add("@precio", SqlDbType.Decimal).Value = producto.Precio;
                command.Parameters.Add("@stock", SqlDbType.Int).Value = producto.Stock;
                command.Parameters.Add("@estado", SqlDbType.Int).Value = producto.Eliminado_id;
                command.Parameters.Add("@categoria", SqlDbType.Int).Value = producto.Id_categoria;
                command.Parameters.Add("@autor", SqlDbType.Int).Value = producto.Id_autor;
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
                command.CommandText = @"SELECT l.id_libro, 
                                        l.titulo, 
                                        l.editorial, 
                                        l.precio,
                                        l.stock, 
                                        l.eliminado,
                                        l.id_categoria,         
                                        l.id_autor,
                                        e.nombre_estado, 
                                        c.nombre_categoria, 
                                        a.alias_autor 
                                FROM libro as l
                                inner join estado as e on l.eliminado = e.id_estado
                                inner join categoria as c on l.id_categoria = c.id_categoria
                                inner join autor as a on l.id_autor = a.id_autor
                                ORDER BY 
                                id_libro DESC;";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var producto = new ProductoModel
                        {
                            Id_libro = Convert.ToInt32(reader["id_libro"]),
                            Titulo = reader["titulo"].ToString(),
                            Editorial = reader["editorial"].ToString(),
                            Precio = Convert.ToDecimal(reader["precio"]),
                            Stock = Convert.ToInt32(reader["stock"]),
                            Eliminado_id = Convert.ToInt32(reader["eliminado"]),
                            Id_categoria = Convert.ToInt32(reader["id_categoria"]),
                            Id_autor = Convert.ToInt32(reader["id_autor"]),
                            Nombre_autor = reader["alias_autor"].ToString(),
                            Nombre_categoria = reader["nombre_categoria"].ToString(),
                            Nombre_estado = reader["nombre_estado"].ToString()
                        };
                        productoList.Add(producto);
                    }
                }
            }
            return productoList;
        }

        public IEnumerable<AutorModel> GetAutor()
        {
            //lista de estados
            var autorList = new List<AutorModel>();
            //consultas sql
            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var command = new Microsoft.Data.SqlClient.SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT *  FROM autor  
                                            WHERE id_estado = 0
                                        ORDER BY id_autor DESC";
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

        public IEnumerable<ProductoModel> GetByValueCategoria(string value)
        {
            var productoList = new List<ProductoModel>();
            string categoria = value;

            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var command = new Microsoft.Data.SqlClient.SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = @"SELECT l.id_libro, 
                                                l.titulo, 
                                                l.editorial, 
                                                l.precio, 
                                                l.stock, 
                                                l.eliminado, 
                                                l.id_categoria ,
                                                l.id_autor,
                                                e.nombre_estado,    
                                                c.nombre_categoria, 
                                                a.alias_autor   
                                        FROM libro as l
                                        INNER JOIN categoria as c ON l.id_categoria = c.id_categoria
                                        INNER JOIN estado as e ON l.eliminado = e.id_estado   
                                        INNER JOIN autor as a ON l.id_autor = a.id_autor
                                        WHERE  c.nombre_categoria LIKE @categoria+'%'
                                        ORDER BY l.id_libro DESC";

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
                            Precio = Convert.ToDecimal(reader["precio"]),
                            Stock = Convert.ToInt32(reader["stock"]),
                            Eliminado_id = Convert.ToInt32(reader["eliminado"]),
                            Id_categoria = Convert.ToInt32(reader["id_categoria"]),
                            Id_autor = Convert.ToInt32(reader["id_autor"]),
                            Nombre_autor = reader["alias_autor"].ToString(),
                            Nombre_categoria = reader["nombre_categoria"].ToString(),
                            Nombre_estado = reader["nombre_estado"].ToString()

                        };
                        productoList.Add(producto);
                    }
                }
            }
            return productoList;
        }

        public IEnumerable<ProductoModel> GetByStockMenorOIgual(int value)
        {
            var productoList = new List<ProductoModel>();
            int stockMinimo = value;

            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var command = new Microsoft.Data.SqlClient.SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = @"SELECT l.id_libro, 
                                                l.titulo, 
                                                l.editorial, 
                                                l.precio, 
                                                l.stock, 
                                                l.eliminado, 
                                                l.id_categoria ,
                                                l.id_autor,
                                                e.nombre_estado,    
                                                c.nombre_categoria, 
                                                a.alias_autor   
                                        FROM libro as l
                                        INNER JOIN categoria as c ON l.id_categoria = c.id_categoria
                                        INNER JOIN estado as e ON l.eliminado = e.id_estado   
                                        INNER JOIN autor as a ON l.id_autor = a.id_autor
                                        WHERE  l.stock <=  @stock and l.eliminado = 0
                                        ORDER BY l.id_libro DESC";

                command.Parameters.Add("@stock", SqlDbType.Int).Value = stockMinimo;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var producto = new ProductoModel
                        {
                            Id_libro = Convert.ToInt32(reader["id_libro"]),
                            Titulo = reader["titulo"].ToString(),
                            Editorial = reader["editorial"].ToString(),
                            Precio = Convert.ToDecimal(reader["precio"]),
                            Stock = Convert.ToInt32(reader["stock"]),
                            Eliminado_id = Convert.ToInt32(reader["eliminado"]),
                            Id_categoria = Convert.ToInt32(reader["id_categoria"]),
                            Id_autor = Convert.ToInt32(reader["id_autor"]),
                            Nombre_autor = reader["alias_autor"].ToString(),
                            Nombre_categoria = reader["nombre_categoria"].ToString(),
                            Nombre_estado = reader["nombre_estado"].ToString()

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

                command.CommandText = @"SELECT l.id_libro, 
                                                l.titulo, 
                                                l.editorial, 
                                                l.precio, 
                                                l.stock, 
                                                l.eliminado,    
                                                l.id_categoria, 
                                                l.id_autor,
                                                e.nombre_estado,
                                                c.nombre_categoria,     
                                                a.alias_autor
                                    FROM libro as l
                                    INNER JOIN categoria as c ON l.id_categoria = c.id_categoria    
                                    INNER JOIN estado as e ON l.eliminado = e.id_estado
                                    INNER JOIN autor as a ON l.id_autor = a.id_autor
                                    WHERE l.titulo like @titulo+'%' 
                                    ORDER BY l.id_libro DESC";

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
                            Precio = Convert.ToDecimal(reader["precio"]),
                            Stock = Convert.ToInt32(reader["stock"]),
                            Eliminado_id = Convert.ToInt32(reader["eliminado"]),
                            Id_categoria = Convert.ToInt32(reader["id_categoria"]),
                            Id_autor = Convert.ToInt32(reader["id_autor"]),
                            Nombre_autor = reader["alias_autor"].ToString(),
                            Nombre_categoria = reader["nombre_categoria"].ToString(),
                            Nombre_estado = reader["nombre_estado"].ToString()
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
                                           WHERE id_estado = 0
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

                var sql_consulta = new StringBuilder();
                sql_consulta.Append("UPDATE libro SET titulo = @titulo,");
                sql_consulta.Append("editorial =@editorial,");
                sql_consulta.Append("precio=@precio,");
                sql_consulta.Append("stock=@stock,");
                sql_consulta.Append("eliminado =@estado ");

                if (producto.Id_categoria != 99)
                {
                    sql_consulta.Append(", id_categoria =@categoria ");
                    command.Parameters.Add("@categoria", SqlDbType.Int).Value = producto.Id_categoria;
                }
                if (producto.Id_autor != 99)
                {
                    sql_consulta.Append(", id_autor =@autor ");
                    command.Parameters.Add("@autor", SqlDbType.Int).Value = producto.Id_autor;
                }
                sql_consulta.Append("WHERE id_libro = @id_libro");

                command.CommandText = sql_consulta.ToString();
                /*
                command.CommandText = @"UPDATE libro SET titulo =@titulo,
                                        editorial =@editorial,
                                        precio=@precio,
                                        stock=@stock,
                                        eliminado =@estado,
                                        id_categoria =@categoria,
                                        id_autor =@autor
                                        WHERE id_libro = @id_libro";*/

                command.Parameters.Add("@id_libro", SqlDbType.Int).Value = producto.Id_libro;
                command.Parameters.Add("@titulo", SqlDbType.NVarChar).Value = producto.Titulo;
                command.Parameters.Add("@editorial", SqlDbType.NVarChar).Value = producto.Editorial;
                command.Parameters.Add("@stock", SqlDbType.Int).Value = producto.Stock;
                command.Parameters.Add("@precio", SqlDbType.Decimal).Value = producto.Precio;
                command.Parameters.Add("@estado", SqlDbType.Int).Value = producto.Eliminado_id;
                //command.Parameters.Add("@categoria", SqlDbType.Int).Value = producto.Id_categoria;
                //command.Parameters.Add("@autor", SqlDbType.Int).Value = producto.Id_autor;
                command.ExecuteNonQuery();
            }
        }
        public void ActualizarStock(int idProducto, int cantidad)
        {
            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var command = new Microsoft.Data.SqlClient.SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE libro SET stock = stock + @cantidad 
                              WHERE id_libro = @id_libro";
                command.Parameters.Add("@id_libro", SqlDbType.Int).Value = idProducto;
                command.Parameters.Add("@cantidad", SqlDbType.Int).Value = cantidad;
                command.ExecuteNonQuery();
            }



        }
    }
}
