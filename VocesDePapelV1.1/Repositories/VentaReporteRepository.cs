using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Repositories
{
    public class VentaReporteRepository : BaseRepository, IVentaReporteRepository
    {
        public VentaReporteRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Obtener ventas por rango de fechas
        public IEnumerable<VentaReporteModel> GetVentasPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            var ventasList = new List<VentaReporteModel>();

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = @"
                    SELECT
                        vc.id_venta_cabecera as IdVenta,
                        vc.fecha_hora as FechaVenta,
                        c.nombre_razon_social as NombreCliente,
                        u.nombre + ' ' + u.apellido as NombreVendedor,
                        vc.total_venta as TotalVenta,
                        e.nombre_estado as EstadoVenta,
                        COUNT(vd.id_detalle_venta) as CantidadProductos,
                        'Efectivo' as FormaPago
                    FROM venta_cabecera vc
                    INNER JOIN cliente c ON vc.id_cliente = c.id_cliente
                    INNER JOIN usuario u ON vc.id_usuario = u.id_usuario
                    INNER JOIN estado e ON vc.id_estado = e.id_estado
                    LEFT JOIN detalle_venta vd ON vc.id_venta_cabecera = vd.id_venta_cabecera
                    WHERE vc.fecha_hora BETWEEN @fechaInicio AND @fechaFin
                    GROUP BY 
                        vc.id_venta_cabecera, vc.fecha_hora, c.nombre_razon_social,
                        u.nombre, u.apellido, vc.total_venta, e.nombre_estado
                    ORDER BY vc.fecha_hora DESC";

                command.Parameters.Add("@fechaInicio", SqlDbType.DateTime).Value = fechaInicio;
                command.Parameters.Add("@fechaFin", SqlDbType.DateTime).Value = fechaFin;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var venta = new VentaReporteModel
                        {
                            IdVenta = Convert.ToInt32(reader["IdVenta"]),
                            FechaVenta = Convert.ToDateTime(reader["FechaVenta"]),
                            NombreCliente = reader["NombreCliente"].ToString(),
                            NombreVendedor = reader["NombreVendedor"].ToString(),
                            TotalVenta = Convert.ToDecimal(reader["TotalVenta"]),
                            EstadoVenta = reader["EstadoVenta"].ToString(),
                            CantidadProductos = Convert.ToInt32(reader["CantidadProductos"]),
                            FormaPago = reader["FormaPago"].ToString()
                        };
                        ventasList.Add(venta);
                    }
                }
            }
            return ventasList;
        }

        //  Obtener total de ventas en período
        public decimal GetTotalVentasPeriodo(DateTime fechaInicio, DateTime fechaFin)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = @"
                    SELECT ISNULL(SUM(total_venta), 0) as Total
                    FROM venta_cabecera 
                    WHERE fecha_hora BETWEEN @fechaInicio AND @fechaFin
                    AND id_estado = 0";

                command.Parameters.Add("@fechaInicio", SqlDbType.DateTime).Value = fechaInicio;
                command.Parameters.Add("@fechaFin", SqlDbType.DateTime).Value = fechaFin;

                var result = command.ExecuteScalar();
                return result != null ? Convert.ToDecimal(result) : 0;
            }
        }

        // Obtener cantidad de ventas en período
        public int GetCantidadVentasPeriodo(DateTime fechaInicio, DateTime fechaFin)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = @"
                    SELECT COUNT(*) as Cantidad
                    FROM venta_cabecera 
                    WHERE fecha_hora BETWEEN @fechaInicio AND @fechaFin
                    AND id_estado = 0";

                command.Parameters.Add("@fechaInicio", SqlDbType.DateTime).Value = fechaInicio;
                command.Parameters.Add("@fechaFin", SqlDbType.DateTime).Value = fechaFin;

                return (int)command.ExecuteScalar();
            }
        }

        // Métodos adicionales (implementación similar)
        public IEnumerable<VentaReporteModel> GetVentasPorVendedor(int idVendedor)
        {
            // Implementación similar con filtro por vendedor
            var ventasList = new List<VentaReporteModel>();
            // ... código similar al anterior con WHERE vc.id_usuario = @idVendedor
            return ventasList;
        }

        public IEnumerable<VentaReporteModel> GetTop10Ventas()
        {
            // Implementación para top 10 ventas
            var ventasList = new List<VentaReporteModel>();
            // ... código con ORDER BY vc.total_venta DESC LIMIT 10
            return ventasList;
        }

        public IEnumerable<VentaReporteModel> GetVentasPorCliente(string criterioCliente)
        {
            throw new NotImplementedException();
        }
    }
}
