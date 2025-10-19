using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Repositories
{
    public class VentaCabeceraRepository : BaseRepository, IVentaCabeceraRepository
    {
        public VentaCabeceraRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(VentaCabeceraModel ventaCabecera)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"
                    INSERT INTO venta_cabecera 
                    (fecha_hora, total_venta, id_cliente, id_usuario, id_estado)
                    VALUES 
                    (@fecha_hora, @total_venta, @id_cliente, @id_usuario, @id_estado);
                    SELECT SCOPE_IDENTITY();";

                command.Parameters.Add("@fecha_hora", SqlDbType.DateTime).Value = ventaCabecera.Fecha_hora;
                command.Parameters.Add("@total_venta", SqlDbType.Decimal).Value = ventaCabecera.Total_venta;
                command.Parameters.Add("@id_cliente", SqlDbType.NVarChar).Value = ventaCabecera.Id_cliente;
                command.Parameters.Add("@id_usuario", SqlDbType.Int).Value = ventaCabecera.Id_usuario;
                command.Parameters.Add("@id_estado", SqlDbType.Int).Value = ventaCabecera.Id_estado;

                ventaCabecera.Id_venta_cabecera = Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public void Eliminar(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM venta_cabecera WHERE id_venta_cabecera = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<VentaCabeceraModel> GetAll()
        {
            var ventaList = new List<VentaCabeceraModel>();

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"
                    SELECT id_venta_cabecera, fecha_hora, total_venta, id_cliente, id_usuario, id_estado
                    FROM venta_cabecera 
                    ORDER BY id_venta_cabecera DESC";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var venta = new VentaCabeceraModel
                        {
                            Id_venta_cabecera = Convert.ToInt32(reader["id_venta_cabecera"]),
                            Fecha_hora = Convert.ToDateTime(reader["fecha_hora"]),
                            Total_venta = Convert.ToDecimal(reader["total_venta"]),
                            Id_cliente = reader["id_cliente"].ToString(),
                            Id_usuario = Convert.ToInt32(reader["id_usuario"]),
                            Id_estado = Convert.ToInt32(reader["id_estado"])
                        };
                        ventaList.Add(venta);
                    }
                }
            }
            return ventaList;
        }

        public IEnumerable<VentaCabeceraModel> GetByValue(string value)
        {
            var ventaList = new List<VentaCabeceraModel>();
            string searchValue = $"%{value}%";

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"
                    SELECT id_venta_cabecera, fecha_hora, total_venta, id_cliente, id_usuario, id_estado
                    FROM venta_cabecera 
                    WHERE id_cliente LIKE @searchValue 
                       OR id_venta_cabecera LIKE @searchValue
                    ORDER BY id_venta_cabecera DESC";

                command.Parameters.Add("@searchValue", SqlDbType.NVarChar).Value = searchValue;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var venta = new VentaCabeceraModel
                        {
                            Id_venta_cabecera = Convert.ToInt32(reader["id_venta_cabecera"]),
                            Fecha_hora = Convert.ToDateTime(reader["fecha_hora"]),
                            Total_venta = Convert.ToDecimal(reader["total_venta"]),
                            Id_cliente = reader["id_cliente"].ToString(),
                            Id_usuario = Convert.ToInt32(reader["id_usuario"]),
                            Id_estado = Convert.ToInt32(reader["id_estado"])
                        };
                        ventaList.Add(venta);
                    }
                }
            }
            return ventaList;
        }
        // Obtiene una venta por su ID
        public VentaCabeceraModel ObtenerPorId(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"
                    SELECT id_venta_cabecera, fecha_hora, total_venta, id_cliente, id_usuario, id_estado
                    FROM venta_cabecera 
                    WHERE id_venta_cabecera = @id";

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new VentaCabeceraModel
                        {
                            Id_venta_cabecera = Convert.ToInt32(reader["id_venta_cabecera"]),
                            Fecha_hora = Convert.ToDateTime(reader["fecha_hora"]),
                            Total_venta = Convert.ToDecimal(reader["total_venta"]),
                            Id_cliente = reader["id_cliente"].ToString(),
                            Id_usuario = Convert.ToInt32(reader["id_usuario"]),
                            Id_estado = Convert.ToInt32(reader["id_estado"])
                        };
                    }
                }
            }
            return null;
        }

        public int ObtenerProximoNumeroFactura()
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                // Verificar si hay registros en la tabla
                command.CommandText = "SELECT COUNT(*) FROM venta_cabecera";
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count == 0)
                {
                    // Si no hay registros, empezar desde 1000
                    return 1000;
                }
                else
                {
                    // Si hay registros, obtener el máximo + 1
                    command.CommandText = "SELECT ISNULL(MAX(id_venta_cabecera), 0) + 1 FROM venta_cabecera";
                    var resultado = command.ExecuteScalar();
                    return resultado != null ? Convert.ToInt32(resultado) : 1000;
                }
            }
        }

        public void Modificar(VentaCabeceraModel ventaCabecera)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"
                    UPDATE venta_cabecera SET 
                    fecha_hora = @fecha_hora, 
                    total_venta = @total_venta, 
                    id_cliente = @id_cliente, 
                    id_usuario = @id_usuario, 
                    id_estado = @id_estado
                    WHERE id_venta_cabecera = @id_venta_cabecera";

                command.Parameters.Add("@id_venta_cabecera", SqlDbType.Int).Value = ventaCabecera.Id_venta_cabecera;
                command.Parameters.Add("@fecha_hora", SqlDbType.DateTime).Value = ventaCabecera.Fecha_hora;
                command.Parameters.Add("@total_venta", SqlDbType.Decimal).Value = ventaCabecera.Total_venta;
                command.Parameters.Add("@id_cliente", SqlDbType.NVarChar).Value = ventaCabecera.Id_cliente;
                command.Parameters.Add("@id_usuario", SqlDbType.Int).Value = ventaCabecera.Id_usuario;
                command.Parameters.Add("@id_estado", SqlDbType.Int).Value = ventaCabecera.Id_estado;

                command.ExecuteNonQuery();
            }
        }
    }
}
