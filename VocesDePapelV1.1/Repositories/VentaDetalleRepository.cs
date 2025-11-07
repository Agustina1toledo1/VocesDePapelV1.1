using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using VocesDePapelV1._1.Models;
using System.Threading.Tasks;

namespace VocesDePapelV1._1.Repositories
{
    public class VentaDetalleRepository : BaseRepository, IVentaDetalleRepository
    {
        public VentaDetalleRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(VentaDetalleModel ventaDetalle)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"
                    INSERT INTO venta_detalle 
                    (cantidad, precio_unitario, id_venta_cabecera, id_libro)
                    VALUES 
                    (@cantidad, @precio_unitario, @id_venta_cabecera, @id_libro)";

                command.Parameters.Add("@cantidad", SqlDbType.Int).Value = ventaDetalle.Cantidad;
                command.Parameters.Add("@precio_unitario", SqlDbType.Decimal).Value = ventaDetalle.Precio_unitario;
                command.Parameters.Add("@id_venta_cabecera", SqlDbType.Int).Value = ventaDetalle.Id_venta_cabecera;
                command.Parameters.Add("@id_libro", SqlDbType.Int).Value = ventaDetalle.Id_libro;

                command.ExecuteNonQuery();
            }
        }

        public void AddRange(IEnumerable<VentaDetalleModel> detalles)
        {
            foreach (var detalle in detalles)
            {
                Add(detalle);
            }
        }

        public IEnumerable<VentaDetalleModel> GetByVentaId(int ventaId)
        {
            var detalles = new List<VentaDetalleModel>();

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"
                    SELECT vd.*, l.titulo as Titulo_libro
                    FROM venta_detalle vd
                    INNER JOIN libro l ON vd.id_libro = l.id_libro
                    WHERE vd.id_venta_cabecera = @ventaId";

                command.Parameters.Add("@ventaId", SqlDbType.Int).Value = ventaId;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        detalles.Add(new VentaDetalleModel
                        {
                            Id_venta_detalle = Convert.ToInt32(reader["id_venta_detalle"]),
                            Cantidad = Convert.ToInt32(reader["cantidad"]),
                            Precio_unitario = Convert.ToDecimal(reader["precio_unitario"]),
                            Id_venta_cabecera = Convert.ToInt32(reader["id_venta_cabecera"]),
                            Id_libro = Convert.ToInt32(reader["id_libro"]),
                            //Titulo_libro = reader["Titulo_libro"].ToString()
                        });
                    }
                }
            }
            return detalles;
        }

        public void EliminarPorVentaId(int ventaId)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM venta_detalle WHERE id_venta_cabecera = @ventaId";
                command.Parameters.Add("@ventaId", SqlDbType.Int).Value = ventaId;
                command.ExecuteNonQuery();
            }
        }
    }
}
