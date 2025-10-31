using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient; // Reemplaza System.Data.SqlClient por Microsoft.Data.SqlClient

namespace VocesDePapelV1._1.Servicios
{
    public class BackupService
    {
        private string connectionString;
        public BackupService(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool GenerarBackup(string rutaDestino, string nombreArchivo)
        {
            // Lógica para generar el backup de la base de datos
            try
            {
                string rutaCompleta = Path.Combine(rutaDestino, nombreArchivo);
                string nombreBD = new Microsoft.Data.SqlClient.SqlConnectionStringBuilder(connectionString).InitialCatalog;

                string comandoBackup = $@"
                BACKUP DATABASE [{nombreBD}]
                TO DISK = '{rutaCompleta}'
                WITH FORMAT, NAME = 'Backup generado desde aplicación'";

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand(comandoBackup, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar backup: {ex.Message}");
                return false;
            }
        }
    }
}
