using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocesDePapelV1._1.Views
{
    public interface IProductoSearchView2
    {
        string Message { get; set; }
        bool IsSuccessful { get; set; }

        event EventHandler SelectEvent; //evento para seleccionar
        event EventHandler CancelEvent; //evento para cancelar

        //metodos
        void SetProductoListBindingSource(object productoList); //metodo para enlazar la lista de productos

        void Show(); //metodo para mostrar la vista
    }

}
