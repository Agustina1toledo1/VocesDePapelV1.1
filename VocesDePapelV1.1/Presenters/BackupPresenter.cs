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
            //mostramos la vista
            this.view.Show();
        }

        public void generarBackup(object? sender, EventArgs e)
        {
            
        }
    }
}
