using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocesDePapelV1._1.Views
{
    public interface IGerenteReporteLibroMasVendidos
    {
        DateTime FechaInicio { get; set; } //propiedad para la fecha de inicio
        DateTime FechaFin { get; set; } //propiedad para la fecha de fin

        string CantidaLibrosVendidos { get; set; }
        string Message { get; set; }
        bool IsSuccessful { get; set; }
        string CategoriaMasVendidaLabel { set; }
        string TotalRecaudadoLabel { set; }
        //eventos
        event EventHandler GenerateReportEvent;
        event EventHandler SearchEvent;

        //metodos
        void SetLibroMasVendidoListBindingSource(object libroMasVendidoList); //metodo para enlazar la lista de libros mas vendidos
        void Show(); //mostrar formulario
    }
}
