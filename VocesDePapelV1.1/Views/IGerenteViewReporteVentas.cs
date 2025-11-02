using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VocesDePapelV1._1.Views
{
    public interface IGerenteViewReporteVentas
    {
        // Propiedades
        string FechaInicio { get; set; }
        string FechaFin { get; set; }
        string TipoReporte { get; set; }
        string FiltroAdicional { get; set; }
        bool IncluirDetalles { get; set; }

        // Resultados
        string TotalVentasPeriodo { get; set; }
        string CantidadVentasPeriodo { get; set; }
        string PromedioVenta { get; set; }
       // string VentaMasAlta { get; set; }
        //string VentaMasBaja { get; set; }
        string CantidadVentas { get; set; }
        string TotalVentas { get; set; }

        // Mensajes
        string Message { get; set; }
        bool IsSuccessful { get; set; }
        //Action<object, EventArgs> LimpiarFiltrosEvent { get; set; }

        // Eventos
        event EventHandler SearchEvent;
        event EventHandler GenerateReportEvent;
        event EventHandler ExportExcelEvent;
       event EventHandler LimpiarFiltrosEvent;

        // Métodos
        void SetVentasListBindingSource(BindingSource ventasList);
        void Show();
    }

}
