using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Repositories
{
    public class VentaDetalleRepository2 : BaseRepository, IVentaDetalleRepository2
    {
        public VentaDetalleRepository2(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(VentaDetalleModel2 ventaDetalle)
        {
            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();

                command.CommandText = @"INSERT INTO detalle_venta(cantidad, precio_unitario,
                                        id_venta_cabecera, id_libro, subtotal)
                                        VALUES (@cantidad, @precio_unitario, @id_venta_cabecera, @id_libro,@subtotal);";

                command.Parameters.Add("@cantidad", System.Data.SqlDbType.Int).Value = ventaDetalle.Cantidad;
                command.Parameters.Add("@precio_unitario", System.Data.SqlDbType.Decimal).Value = ventaDetalle.Precio_unitario;
                command.Parameters.Add("@id_venta_cabecera", System.Data.SqlDbType.Int).Value = ventaDetalle.Id_venta_cabecera;
                command.Parameters.Add("@id_libro", System.Data.SqlDbType.Int).Value = ventaDetalle.Id_libro;
                command.Parameters.Add("@subtotal", System.Data.SqlDbType.Decimal).Value = ventaDetalle.Subtotal;

                command.ExecuteNonQuery();
            }
        }

        public void EliminarPorVentaId(int ventaId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VentaDetalleModel2> GetAll()
        {
            var ventaDetalleList = new List<VentaDetalleModel2>();
            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var command = new Microsoft.Data.SqlClient.SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT vd.id_detalle_venta,
                                                vd.cantidad,
                                                vd.precio_unitario,
                                                vd.id_venta_cabecera,
                                                vd.id_libro,
                                                l.titulo,
                                                vd.subtotal
                                        FROM    
                                            detalle_venta as vd
                                        INNER JOIN libro as l on vd.id_libro = l.id_libro
                                        ORDER BY
                                            vd.id_venta_cabecera;";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ventaDetalle = new VentaDetalleModel2
                        {
                            Id_venta_detalle = Convert.ToInt32(reader["id_detalle_venta"]),
                            Cantidad = Convert.ToInt32(reader["cantidad"]),
                            Precio_unitario = Convert.ToDecimal(reader["precio_unitario"]),
                            Id_venta_cabecera = Convert.ToInt32(reader["id_venta_cabecera"]),
                            Id_libro = Convert.ToInt32(reader["id_libro"]),
                            Titulo_libro = reader["titulo"].ToString(),
                            Subtotal = Convert.ToDecimal(reader["subtotal"])
                        };
                        ventaDetalleList.Add(ventaDetalle);
                    }
                }
            }
            return ventaDetalleList;
        }

        public IEnumerable<VentaDetalleModel2> GetByVentaId(int ventaId)
        {
            var ventaDetalleList = new List<VentaDetalleModel2>();
            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var command = new Microsoft.Data.SqlClient.SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT vd.id_detalle_venta,
                                                vd.cantidad,
                                                vd.precio_unitario,
                                                vd.id_venta_cabecera,
                                                vd.id_libro,
                                                l.titulo,
                                                vd.subtotal
                                        FROM    
                                            detalle_venta as vd
                                        INNER JOIN libro as l on vd.id_libro = l.id_libro
                                        WHERE vd.id_venta_cabecera = @venta_cabecera
                                        ORDER BY
                                            vd.id_venta_cabecera;";
                command.Parameters.Add("@venta_cabecera", SqlDbType.Int).Value = ventaId;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ventaDetalle = new VentaDetalleModel2
                        {
                            Id_venta_detalle = Convert.ToInt32(reader["id_detalle_venta"]),
                            Cantidad = Convert.ToInt32(reader["cantidad"]),
                            Precio_unitario = Convert.ToDecimal(reader["precio_unitario"]),
                            Id_venta_cabecera = Convert.ToInt32(reader["id_venta_cabecera"]),
                            Id_libro = Convert.ToInt32(reader["id_libro"]),
                            Titulo_libro = reader["titulo"].ToString(),
                            Subtotal = Convert.ToDecimal(reader["subtotal"])
                        };
                        ventaDetalleList.Add(ventaDetalle);
                    }
                }
            }
            return ventaDetalleList;
        }

    }
}
