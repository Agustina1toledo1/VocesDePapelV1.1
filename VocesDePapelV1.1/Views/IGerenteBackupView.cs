using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocesDePapelV1._1.Views
{
    public interface IGerenteBackupView
    {
        //propiedades
        string RutaBackup { get; set; }
        string Message { get; set; }
        bool IsSuccessful { get; set; }

        //eventos
        event EventHandler GenerarBackupEvent;
        void Show(); //mostrar formulario
    }
}
