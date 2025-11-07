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
        string FechaInicio { get; set; }
        string FechaFin { get; set; }
        string TipoReporte { get; set; }
<<<<<<< HEAD
        bool IncluirDetalles { get; set; }
        List<UsuarioModel> ListaVendedores { set; }
        List<ClienteModel> ListaClientes { set; }
        string ValorBusqueda { get; } // Valor seleccionado en el ComboBox
        string TextoBusqueda { set; } // Texto a mostrar en el ComboBox
        int? IdVendedorSeleccionado { get; set; }
        string NombreVendedorSeleccionado { get; set; }
        // bool FiltroVendedorHabilitado { set; }
        //  bool FiltroVendedorVisible { get; set; }       
        // Propiedades para filtros vendedor
        // bool EsModoVendedor { get; set; }
        bool ComboVendedorHabilitado { set; }
        bool ComboBusquedaHabilitado { set; }
        string EtiquetaBusqueda { set; }
        string TextoVendedor { set; }////
        int VendedorSeleccionadoId { set; }
        //int IdVendedorAutomatico { set; }
       // string TxtVendedorAuto { set; }
        bool CmbTipoReporteEnabled { get; set; }
       // Resultados
=======
        string FiltroAdicional { get; set; }
        bool FiltroVendedorVisible { get; set; }
        bool IncluirDetalles { get; set; }
        bool EsModoVendedor { get; set; }
        int? IdVendedorSeleccionado { get; set; }

        int IdVendedorAutomatico { get; set; }
        string TxtVendedorAuto { get; set; }
        bool CmbTipoReporteEnabled { get; set; }
        List<UsuarioModel> ListaVendedores { get; set; }

        // Resultados
>>>>>>> se agrega acceso a reporte de ventas para vendedor con  filtro restringido
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
        List<UsuarioModel> DatosComboBusqueda { get; set; }


        // Eventos
        event EventHandler SearchEvent;
<<<<<<< HEAD
        event EventHandler GenerateReportEvent;       
        event EventHandler LimpiarFiltrosEvent;
        event EventHandler TipoReporteChangedEvent;
=======
        event EventHandler GenerateReportEvent;
        event EventHandler ExportExcelEvent;
        event EventHandler LimpiarFiltrosEvent;
>>>>>>> se agrega acceso a reporte de ventas para vendedor con  filtro restringido

        // Métodos
        void SetVentasListBindingSource(BindingSource ventasList);
        void Show();
    }

}
