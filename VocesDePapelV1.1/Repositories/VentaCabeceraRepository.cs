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
                command.Parameters.Add("@id_cliente", SqlDbType.Int).Value = ventaCabecera.Id_cliente;
                command.Parameters.Add("@id_usuario", SqlDbType.Int).Value = ventaCabecera.Id_usuario;
                command.Parameters.Add("@id_estado", SqlDbType.Int).Value = ventaCabecera.Id_estado;
                // Asignar el ID generado al modelo
                ventaCabecera.Id_venta_cabecera = Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public void eliminar(int id)
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
        // Obtiene todas las ventas
        public IEnumerable<VentaCabeceraModel> GetAll()
        {
            var ventaList = new List<VentaCabeceraModel>();

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"
                    SELECT vc.*, 
                           c.nombre_razon_social as Nombre_cliente,
                           u.nombre + ' ' + u.apellido as Nombre_vendedor,
                           e.nombre_estado as Nombre_estado
                    FROM venta_cabecera vc
                    LEFT JOIN cliente c ON vc.id_cliente = c.id_cliente
                    LEFT JOIN usuario u ON vc.id_usuario = u.id_usuario
                    LEFT JOIN estado e ON vc.id_estado = e.id_estado
                    ORDER BY id_venta_cabecera DESC";
                // Ejecutar el comando y leer los resultados
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var venta = new VentaCabeceraModel
                        {
                            Id_venta_cabecera = Convert.ToInt32(reader["id_venta_cabecera"]),
                            Fecha_hora = Convert.ToDateTime(reader["fecha_hora"]),
                            Total_venta = Convert.ToDecimal(reader["total_venta"]),
                            Id_cliente = Convert.ToInt32(reader["id_cliente"]),
                            Id_usuario = Convert.ToInt32(reader["id_usuario"]),
                            Id_estado = Convert.ToInt32(reader["id_estado"]),
                            Nombre_cliente = reader["Nombre_cliente"]?.ToString() ?? "N/A",
                            Nombre_vendedor = reader["Nombre_vendedor"]?.ToString() ?? "N/A",
                            Nombre_estado = reader["Nombre_estado"]?.ToString() ?? "N/A"
                        };
                        ventaList.Add(venta);
                    }
                }
            }
            return ventaList;
        }
        // Obtiene ventas por un valor de búsqueda
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
                    SELECT vc.*, 
                           c.nombre_razon_social as Nombre_cliente,
                           u.nombre + ' ' + u.apellido as Nombre_vendedor,
                           e.nombre_estado as Nombre_estado
                    FROM venta_cabecera vc
                    LEFT JOIN cliente c ON vc.id_cliente = c.id_cliente
                    LEFT JOIN usuario u ON vc.id_usuario = u.id_usuario
                    LEFT JOIN estado e ON vc.id_estado = e.id_estado
                    WHERE c.nombre_razon_social LIKE @searchValue 
                       OR CONVERT(varchar, vc.id_venta_cabecera) LIKE @searchValue
                       OR u.nombre LIKE @searchValue 
                       OR u.apellido LIKE @searchValue
                     ORDER BY vc.id_venta_cabecera DESC";
                // Agregar el parámetro de búsqueda
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
                            Id_cliente = Convert.ToInt32(reader["id_cliente"]),
                            Id_usuario = Convert.ToInt32(reader["id_usuario"]),
                            Id_estado = Convert.ToInt32(reader["id_estado"]),
                            Nombre_cliente = reader["Nombre_cliente"]?.ToString() ?? "N/A",
                            Nombre_vendedor = reader["Nombre_vendedor"]?.ToString() ?? "N/A",
                            Nombre_estado = reader["Nombre_estado"]?.ToString() ?? "N/A"
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
                    SELECT vc.*, 
                           c.nombre_razon_social as Nombre_cliente,
                           u.nombre + ' ' + u.apellido as Nombre_vendedor,
                           e.nombre_estado as Nombre_estado
                    FROM venta_cabecera vc
                    LEFT JOIN cliente c ON vc.id_cliente = c.id_cliente
                    LEFT JOIN usuario u ON vc.id_usuario = u.id_usuario
                    LEFT JOIN estado e ON vc.id_estado = e.id_estado
                    WHERE vc.id_venta_cabecera = @id";

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
                            Id_cliente = Convert.ToInt32(reader["id_cliente"]),
                            Id_usuario = Convert.ToInt32(reader["id_usuario"]),
                            Id_estado = Convert.ToInt32(reader["id_estado"]),
                            Nombre_cliente = reader["Nombre_cliente"]?.ToString() ?? "N/A",
                            Nombre_vendedor = reader["Nombre_vendedor"]?.ToString() ?? "N/A",
                            Nombre_estado = reader["Nombre_estado"]?.ToString() ?? "N/A"
                        };
                    }
                }
            }
            return null;
        }
        // Obtiene el próximo número de factura
        public int ObtenerProximoNumeroFactura()
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                // Obtener el máximo ID actual + 1
                command.CommandText = "SELECT ISNULL(MAX(id_venta_cabecera), 0) + 1 FROM venta_cabecera";
                var resultado = command.ExecuteScalar();
                return resultado != null ? Convert.ToInt32(resultado) : 1;
            }
        }
        // Modifica una venta existente
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
                command.Parameters.Add("@id_cliente", SqlDbType.Int).Value = ventaCabecera.Id_cliente;
                command.Parameters.Add("@id_usuario", SqlDbType.Int).Value = ventaCabecera.Id_usuario;
                command.Parameters.Add("@id_estado", SqlDbType.Int).Value = ventaCabecera.Id_estado;
                // Ejecutar la actualización
                command.ExecuteNonQuery();
            }
        }

        
        
    }
}
