using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Views
{
    public interface IProductoSearchView
    {

        ProductoModel ProductoSeleccionado { get; }
        event EventHandler<ProductoSeleccionadoEventArgs> ProductoSeleccionadoEvent;
        void ShowView();
        DialogResult ShowDialog();
    }

    public class ProductoSeleccionadoEventArgs : EventArgs
    {
        public ProductoModel Producto { get; }

        public ProductoSeleccionadoEventArgs(ProductoModel producto)
        {
            Producto = producto;
        }
    }
}
