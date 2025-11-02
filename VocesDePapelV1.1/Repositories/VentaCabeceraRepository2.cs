using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Repositories
{
    public class VentaCabeceraRepository2 : BaseRepository, IVentaCabeceraRepository2
    {
        public VentaCabeceraRepository2(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(VentaCabeceraModel2 ventaCabecera)
        {
            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();

                command.CommandText = @"
                                        INSERT INTO venta_cabecera (total_venta, id_cliente, id_usuario, id_estado)
                                        OUTPUT INSERTED.id_venta_cabecera
                                        VALUES (@total_venta, @id_cliente, @id_usuario, @id_estado);";

                command.Parameters.Add("@total_venta", System.Data.SqlDbType.Decimal).Value = ventaCabecera.Total_venta;
                command.Parameters.Add("@id_cliente", System.Data.SqlDbType.Int).Value = ventaCabecera.Id_cliente;
                command.Parameters.Add("@id_usuario", System.Data.SqlDbType.Int).Value = ventaCabecera.Id_usuario;
                command.Parameters.Add("@id_estado", System.Data.SqlDbType.Int).Value = ventaCabecera.Id_estado;

                command.ExecuteNonQuery();
                ventaCabecera.Id_venta_cabecera = (int)command.ExecuteScalar();
            }
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VentaCabeceraModel2> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VentaCabeceraModel2> GetByDate(DateTime inicio, DateTime final)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VentaCabeceraModel2> GetById(int value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VentaCabeceraModel2> GetByVendedorDate(int value, DateTime inicio, DateTime final)
        {
            throw new NotImplementedException();
        }
    }
}
