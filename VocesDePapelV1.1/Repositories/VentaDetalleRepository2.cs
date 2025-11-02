using System;
using System.Collections.Generic;
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

        public IEnumerable<VentaDetalleModel2> GetByVentaId(int ventaId)
        {
            throw new NotImplementedException();
        }
    }
}
