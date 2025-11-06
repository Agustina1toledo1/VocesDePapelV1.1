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

                ventaCabecera.Id_venta_cabecera = (int)command.ExecuteScalar();//ExecuteScalar(),
                                                                               //que ejecuta el INSERT y devuelve el valor de OUTPUT
                                                                               //INSERTED.id_venta_cabecera en una sola operación
            }
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VentaCabeceraModel2> GetAll()
        {
            var ventaCabeceraList = new List<VentaCabeceraModel2>();

            using (var connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
            using (var command = new Microsoft.Data.SqlClient.SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT vc.id_venta_cabecera, 
                                                vc.fecha_hora, 
                                                vc.total_venta, 
                                                c.nombre_razon_social, 
                                                u.nombre,
                                                u.apellido,
                                                e.nombre_estado
                                       FROM  venta_cabecera as vc
                                       INNER JOIN cliente as c on vc.id_cliente = c.id_cliente
                                        INNER JOIN usuario as u on vc.id_usuario = u.id_usuario
                                        INNER JOIN estado as e on vc.estado_id = e.estado_id
                                        ORDER BY
                                                vc.fecha_hora DESC;
                                        ";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var vetaCabecera = new VentaCabeceraModel2
                        {
                            Id_venta_cabecera = Convert.ToInt32(reader["id_venta_cabecera"]),
                            Fecha_hora = (DateTime)reader["fecha_hora"],
                            Total_venta = Convert.ToDecimal(reader["total_venta"]),
                            Nombre_cliente = (reader["nombre_razon_social"]).ToString() ,
                            Nombre_vendedor = (reader["nombre"]).ToString() + (reader["apellido"]).ToString(),
                            Nombre_estado = (reader["nombre_estado"]).ToString()
                        };
                        ventaCabeceraList.Add(vetaCabecera);
                    }
                }

            }
            return ventaCabeceraList;
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
