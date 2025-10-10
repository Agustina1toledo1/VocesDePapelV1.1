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
        Form FormInstance { get; }
        void Show();
    }
}
