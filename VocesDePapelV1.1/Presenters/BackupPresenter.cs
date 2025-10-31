using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Views;
using VocesDePapelV1._1.Servicios;


namespace VocesDePapelV1._1.Presenters
{
    public class BackupPresenter
    {
        //campos        
        private IGerenteBackupView view; //campo privado para la vista usando la interfaz
        private BackupService servicio; //servicio de backup

        public BackupPresenter(IGerenteBackupView view, string connectionString)
        {
            
            this.view = view;
            this.servicio = new BackupService(connectionString);

            //suscribirse a los eventos de la vista
            this.view.GenerarBackupEvent += generarBackup;
            //mostramos la vista
            this.view.Show();
        }

        public void generarBackup(object? sender, EventArgs e)
        {
            //usamos saveFileDialog para mostrar la ruta donde se almacenara el archivo, el nombre incluye el año, mrs, dia_ hora y minutos
            using var dialog = new SaveFileDialog
            {
                Title = "Guardar copia de seguridad",
                Filter = "Archivo de respaldo (*.bak)|*.bak",
                FileName = $"BackupVocesDePapel_{DateTime.Now:yyyyMMdd_HHmm}.bak"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                view.RutaBackup = dialog.FileName;

                string nombreArchivo = Path.GetFileName(view.RutaBackup);
                string carpeta = Path.GetDirectoryName(view.RutaBackup);

                bool exito = servicio.GenerarBackup(carpeta, nombreArchivo);
                view.Message = exito ? "Backup generado correctamente." : "Error al generar el backup.";
                view.IsSuccessful = exito;
            }
            else
            {
                view.IsSuccessful = false;
            }
        }
    }
}
