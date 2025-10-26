using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocesDePapelV1._1.Views
{
    public interface IGerenteReporteLibroStock
    {
        //propiedades
        string StockMinimo { get; set; }
        string Message { get; set; }
        bool IsSuccessful { get; set; }

        //eventos
        event EventHandler GenerateReportEvent;
        event EventHandler SearchEvent;


        //metodos
        void SetProductoFiltradoListBindingSource(object productoList); //metodo para enlazar la lista de productos
        void SetCategoriaListBindingSource(object categoriaList); //metodo para enlazar la lista de categorias
        void SetEstadoListBindingSource(object estadoList); //metodo para enlazar la lista de estados
        void SetAutorListBindingSource(object autorList); //metodo para enlazar la lista de autores
        void Show(); //mostrar formulario
    }
}
