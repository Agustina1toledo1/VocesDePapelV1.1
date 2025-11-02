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
                        (SELECT COUNT(*) FROM detalle_venta vd WHERE vd.id_venta_cabecera = vc.id_venta_cabecera) as CantidadProductos,
                        'Efectivo' as FormaPago
                    FROM venta_cabecera vc
                    INNER JOIN cliente c ON vc.id_cliente = c.id_cliente
                    INNER JOIN usuario u ON vc.id_usuario = u.id_usuario
                    INNER JOIN estado e ON vc.id_estado = e.id_estado
                    WHERE vc.fecha_hora BETWEEN @fechaInicio AND @fechaFin
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

        // Obtener ventas por vendedor
        public IEnumerable<VentaReporteModel> GetVentasPorVendedor(int idVendedor, DateTime fechaInicio, DateTime fechaFin)
        {
            var ventasList = new List<VentaReporteModel>();

            try
            {
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
                        (SELECT COUNT(*) FROM detalle_venta vd WHERE vd.id_venta_cabecera = vc.id_venta_cabecera) as CantidadProductos                
                    FROM venta_cabecera vc
                    INNER JOIN cliente c ON vc.id_cliente = c.id_cliente
                    INNER JOIN usuario u ON vc.id_usuario = u.id_usuario
                    INNER JOIN estado e ON vc.id_estado = e.id_estado
                    WHERE vc.id_usuario = @idVendedor 
                    AND vc.fecha_hora BETWEEN @fechaInicio AND @fechaFin
                    ORDER BY vc.fecha_hora DESC";

                    command.Parameters.Add("@idVendedor", SqlDbType.Int).Value = idVendedor;
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
                            };
                            ventasList.Add(venta);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return ventasList; // Retorna lista vacía
            }

            return ventasList; 
        }
        
        // Obtener total de ventas por vendedor en período
        public decimal GetTotalVentasPorVendedor(int idVendedor, DateTime fechaInicio, DateTime fechaFin)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = @"
            SELECT ISNULL(SUM(total_venta), 0) as Total
            FROM venta_cabecera 
            WHERE id_usuario = @idVendedor
            AND fecha_hora BETWEEN @fechaInicio AND @fechaFin
            AND id_estado = 0";

                command.Parameters.Add("@idVendedor", SqlDbType.Int).Value = idVendedor;
                command.Parameters.Add("@fechaInicio", SqlDbType.DateTime).Value = fechaInicio;
                command.Parameters.Add("@fechaFin", SqlDbType.DateTime).Value = fechaFin;

                var result = command.ExecuteScalar();
                return result != null ? Convert.ToDecimal(result) : 0;
            }
        }

        // Obtener cantidad de ventas por vendedor en período
        public int GetCantidadVentasPorVendedor(int idVendedor, DateTime fechaInicio, DateTime fechaFin)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = @"
                SELECT COUNT(*) as Cantidad
                FROM venta_cabecera 
                WHERE id_usuario = @idVendedor
                AND fecha_hora BETWEEN @fechaInicio AND @fechaFin
                AND id_estado = 0";

                command.Parameters.Add("@idVendedor", SqlDbType.Int).Value = idVendedor;
                command.Parameters.Add("@fechaInicio", SqlDbType.DateTime).Value = fechaInicio;
                command.Parameters.Add("@fechaFin", SqlDbType.DateTime).Value = fechaFin;

                return (int)command.ExecuteScalar();
            }
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
        public UsuarioModel GetVendedorPorId(int idVendedor)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = @"
                    SELECT id_usuario, nombre, apellido, baja,
                           nombre + ' ' + apellido as NombreCompleto
                    FROM usuario 
                    WHERE id_usuario = @idVendedor 
                    AND baja = 0"; // Solo usuarios activos

                command.Parameters.Add("@idVendedor", SqlDbType.Int).Value = idVendedor;

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new UsuarioModel
                        {
                            Id_usuario = Convert.ToInt32(reader["id_usuario"]),
                            Nombre = reader["nombre"].ToString(),
                            Apellido = reader["apellido"].ToString(),
                            Baja = Convert.ToInt32(reader["baja"])
                        };
                    }
                }
            }
            return null; // Si no encuentra el vendedor
        }

        // Obtener todos los vendedores activos
        public IEnumerable<UsuarioModel> GetVendedoresActivos()
        {
            var vendedores = new List<UsuarioModel>();

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = @"
                SELECT u.id_usuario, u.nombre, u.apellido, u.baja, e.nombre_estado
                FROM usuario u
                INNER JOIN estado e ON u.baja = e.id_estado
                WHERE u.baja = 0  -- ← usuarios activos (id_estado = 0 = activo)
                ORDER BY u.nombre, u.apellido";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        vendedores.Add(new UsuarioModel
                        {
                            Id_usuario = Convert.ToInt32(reader["id_usuario"]),
                            Nombre = reader["nombre"].ToString(),
                            Apellido = reader["apellido"].ToString(),
                            Baja = Convert.ToInt32(reader["baja"]),
                            Nombre_estado = reader["nombre_estado"].ToString()
                        });
                    }
                }
            }
            return vendedores;
        }
        public IEnumerable<ClienteModel> GetClientesActivos()
        {
            var clientes = new List<ClienteModel>();

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                command.CommandText = @"
            SELECT id_cliente, nombre_razon_social, cuit, baja
            FROM cliente 
            WHERE baja = 0
            ORDER BY nombre_razon_social";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clientes.Add(new ClienteModel
                        {
                            Id_cliente = Convert.ToInt32(reader["id_cliente"]),
                            Nombre_razon_social = reader["nombre_razon_social"].ToString(),
                            Cuit_cuil = reader["cuit"].ToString()                            
                        });
                    }
                }
            }
            return clientes;
        }

        public IEnumerable<VentaReporteModel> GetVentasPorCliente(string criterioCliente, DateTime fechaInicio, DateTime fechaFin)
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
                (SELECT COUNT(*) FROM detalle_venta vd WHERE vd.id_venta_cabecera = vc.id_venta_cabecera) as CantidadProductos                
            FROM venta_cabecera vc
            INNER JOIN cliente c ON vc.id_cliente = c.id_cliente
            INNER JOIN usuario u ON vc.id_usuario = u.id_usuario
            INNER JOIN estado e ON vc.id_estado = e.id_estado
            WHERE (c.cuit LIKE @criterio + '%' OR c.nombre_razon_social LIKE @criterio + '%')
            AND vc.fecha_hora BETWEEN @fechaInicio AND @fechaFin
            ORDER BY vc.fecha_hora DESC";

                command.Parameters.Add("@criterio", SqlDbType.NVarChar).Value = criterioCliente + "%";
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
                        };
                        ventasList.Add(venta);
                    }
                }
            }
            return ventasList;
        }

    }
}
