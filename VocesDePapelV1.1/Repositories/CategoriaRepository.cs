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
                            (nombre_categoria, id_estado )
                            VALUES
                            (@nombre_categoria, @id_estado);
                    ";
                command.Parameters.Add("@nombre_categoria", SqlDbType.NVarChar).Value = categoria.Nombre_categoria;
                command.Parameters.Add("@id_estado)", SqlDbType.Int).Value = categoria.Estado_id;

                command.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoriaModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoriaModel> GetByValue(string value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EstadoModel> GetEstado()
        {
            throw new NotImplementedException();
        }

        public void Modificar(CategoriaModel usuario)
        {
            throw new NotImplementedException();
        }
    }
}
