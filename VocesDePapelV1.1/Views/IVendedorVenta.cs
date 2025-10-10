using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace VocesDePapelV1._1.Views
{
    public interface IVendedorVenta
    {
        event EventHandler AddNewClienteEvent;
        event EventHandler EditarClienteEvent;
        event EventHandler SearchClienteByCuitEvent;
        Form FormInstance { get; }
        string ClienteCuit { get; set; }
        string ClienteNombre { get; set; }
        string ClienteEmail { get; set; }
        string ClienteTelefono { get; set; }
        void Show();
    }
}
