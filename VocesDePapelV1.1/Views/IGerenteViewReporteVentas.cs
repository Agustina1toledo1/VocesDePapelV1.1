using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Views
{
    public interface IGerenteViewReporteVentas
    {
        // Propiedades
        DateTime FechaInicio { get; set; }
        DateTime FechaFin { get; set; }
        string TipoReporte { get; set; }
       
        List<UsuarioModel> ListaVendedores { set; }
        List<ClienteModel> ListaClientes { set; }
        string ValorBusqueda { get; } // Valor seleccionado en el ComboBox
       
        int? IdVendedorSeleccionado { get; }
        string NombreVendedorSeleccionado { get; set; }
        // bool FiltroVendedorHabilitado { set; }
        //  bool FiltroVendedorVisible { get; set; }       
        // Propiedades para filtros vendedor
        bool EsModoVendedor { get; set; }
        bool ComboVendedorHabilitado { set; }
        bool ComboBusquedaHabilitado { set; }
       
      
        int VendedorSeleccionadoId { set; }
        //int IdVendedorAutomatico { set; }
       // string TxtVendedorAuto { set; }
        bool CmbTipoReporteEnabled { get; set; }
       // Resultados
        string TotalVentasPeriodo { get; set; }
        string CantidadVentasPeriodo { get; set; }
        string PromedioVenta {  get; set; }
       // string VentaMasAlta { get; set; }
        //string VentaMasBaja { get; set; }
        string CantidadVentas { get; set; }
        string TotalVentas { get; set; }

        // Mensajes
        string Message { get; set; }
        bool IsSuccessful { get; set; }
      

        // Eventos
        event EventHandler SearchEvent;
        event EventHandler GenerateReportEvent;       
        event EventHandler LimpiarFiltrosEvent;
        event EventHandler TipoReporteChangedEvent;

        // Métodos
        void SetVentasListBindingSource(BindingSource ventasList);
        void Show();
    }

}
