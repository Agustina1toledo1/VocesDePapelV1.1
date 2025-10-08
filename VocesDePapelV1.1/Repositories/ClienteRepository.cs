using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Repositories;

namespace VocesDePapelV1._1.Models
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly string connectionString;
        public ClienteRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        //  Agregar nuevo cliente
        public void Add(ClienteModel cliente)
        {
            using var connection = new SqlConnection(connectionString);
            using var command = connection.CreateCommand();
            connection.Open();

            // Verificar si el CUIT ya existe
            command.CommandText = "SELECT COUNT(1) FROM cliente WHERE cuit_cuil = @cuit";
            command.Parameters.Add("@cuit", SqlDbType.NVarChar, 20).Value = cliente.Cuit_cuil;

            int existe = (int)command.ExecuteScalar();
            if (existe > 0)
            {
                command.Parameters.Clear();
                throw new InvalidOperationException("El CUIT ingresado ya está registrado.");
            }

            // Insertar nuevo cliente
            command.Parameters.Clear();
            command.CommandText = @"
                INSERT INTO cliente (nombre_razonSocial, cuit_cuil, telefono, email)
                VALUES (@nombre, @cuit, @telefono, @email)";
            command.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = cliente.Nombre_razonSocial;
            command.Parameters.Add("@cuit", SqlDbType.NVarChar).Value = cliente.Cuit_cuil;
            command.Parameters.Add("@telefono", SqlDbType.NVarChar).Value = cliente.Telefono;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = cliente.Email;

            command.ExecuteNonQuery();
        }

        // Modificar cliente existente
        public void Modificar(ClienteModel cliente)
        {
            using var connection = new SqlConnection(connectionString);
            using var command = connection.CreateCommand();
            connection.Open();

            command.CommandText = @"
                UPDATE cliente SET 
                    nombre_razonSocial = @nombre,
                    cuit_cuil = @cuit,
                    telefono = @telefono,
                    email = @email
                WHERE id_cliente = @id";
            command.Parameters.Add("@id", SqlDbType.Int).Value = cliente.Id_cliente;
            command.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = cliente.Nombre_razonSocial;
            command.Parameters.Add("@cuit", SqlDbType.NVarChar).Value = cliente.Cuit_cuil;
            command.Parameters.Add("@telefono", SqlDbType.NVarChar).Value = cliente.Telefono;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = cliente.Email;

            command.ExecuteNonQuery();
        }

        // Eliminar cliente (borrado físico)
        public void Eliminar(int id)
        {
            using var connection = new SqlConnection(connectionString);
            using var command = connection.CreateCommand();
            connection.Open();

            command.CommandText = "DELETE FROM cliente WHERE id_cliente = @id";
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            command.ExecuteNonQuery();
        }

        //  Obtener todos los clientes
        public IEnumerable<ClienteModel> GetAll()
        {
            var lista = new List<ClienteModel>();
            using var connection = new SqlConnection(connectionString);
            using var command = connection.CreateCommand();
            connection.Open();

            command.CommandText = "SELECT * FROM cliente ORDER BY id_cliente DESC";
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new ClienteModel
                {
                    Id_cliente = (int)reader["id_cliente"],
                    Nombre_razonSocial = reader["nombre_razonSocial"].ToString(),
                    Cuit_cuil = reader["cuit_cuil"].ToString(),
                    Telefono = reader["telefono"].ToString(),
                    Email = reader["email"].ToString()
                });
            }
            return lista;
        }

        //  Buscar cliente por nombre o CUIT-CUIL
        public ClienteModel ObtenerPorCuit(string cuit)
        {
            using var connection = new SqlConnection(connectionString);
            using var command = connection.CreateCommand();
            connection.Open();

            command.CommandText = "SELECT * FROM cliente WHERE cuit_cuil = @cuit AND baja = 0";
            command.Parameters.Add("@cuit", SqlDbType.NVarChar).Value = cuit;

            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new ClienteModel
                {
                    Id_cliente = (int)reader["id_cliente"],
                    Nombre_razonSocial = reader["nombre_razonSocial"].ToString(),
                    Cuit_cuil = reader["cuit_cuil"].ToString(),
                    Telefono = reader["telefono"].ToString(),
                    Email = reader["email"].ToString()
                };
            }
            return null;
        }
        public IEnumerable<ClienteModel> GetByValue(string value)
        {
            var lista = new List<ClienteModel>();
            using var connection = new SqlConnection(connectionString);
            using var command = connection.CreateCommand();
            connection.Open();

            command.CommandText = @"
                SELECT * FROM cliente
                WHERE nombre_razonSocial LIKE @value + '%' OR cuit_cuil LIKE @value + '%'
                ORDER BY id_cliente DESC";
            command.Parameters.Add("@value", SqlDbType.NVarChar).Value = value;

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new ClienteModel
                {
                    Id_cliente = (int)reader["id_cliente"],
                    Nombre_razonSocial = reader["nombre_razonSocial"].ToString(),
                    Cuit_cuil = reader["cuit_cuil"].ToString(),
                    Telefono = reader["telefono"].ToString(),
                    Email = reader["email"].ToString()
                });
            }
            return lista;
        }
    }
}