using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocesDePapelV1._1.Views
{
    public interface IAdministradorViewProducto
    {
        //propiedades
        string ProductoId { get; set; }
        string ProductoTitulo { get; set; }
        string ProductoEditorial { get; set; }
        string ProductoPrecio { get; set; }
        string ProductoStock { get; set; }
        string ProductoEliminado { get; set; }
        string ProductoNombreEstado { get; set; }
        string ProductoIdCategoria { get; set; }
        string ProductoNombreCategoria { get; set; }    
        string SearchBy { get; set; }
        string SearchValue { get; set; }
        string Message { get; set; }
        bool IsSuccessful { get; set; }

        //eventos
        event EventHandler SearchEvent; //evento para buscar
        event EventHandler AddNewEvent; //evento para agregar
        event EventHandler EditEvent; //evento para editar
        event EventHandler DeleteEvent; //evento para eliminar
        event EventHandler SaveEvent; //evento para guardar
        event EventHandler CancelEvent; //evento para cancelar

        //metodos
        void SetProductoListBindingSource(object productoList); //metodo para enlazar la lista de productos
        void SetCategoriaListBindingSource(object categoriaList); //metodo para enlazar la lista de categorias
        void SetEstadoListBindingSource(object estadoList); //metodo para enlazar la lista de estados
        void Show(); //metodo para mostrar la vista
    }
}
