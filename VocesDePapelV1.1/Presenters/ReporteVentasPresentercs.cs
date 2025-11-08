using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Repositories;
using VocesDePapelV1._1.Servicios;
using VocesDePapelV1._1.Views;

namespace VocesDePapelV1._1.Presenters
{
    public class ReporteVentasPresenter
    {
        private IGerenteViewReporteVentas view;
        private IVentaReporteRepository repository;
        private BindingSource ventasBindingSource;
        private IEnumerable<VentaReporteModel> ventasList;
        private bool busquedaRealizada = false;

        public ReporteVentasPresenter(IGerenteViewReporteVentas view, IVentaReporteRepository repository,
                                  bool esModoVendedor = false, int? idVendedor = null)
        {            
            this.view = view;
            this.repository = repository;
            this.ventasBindingSource = new BindingSource();

            

            // Configurar modo de la vista
            if (esModoVendedor && idVendedor.HasValue)
            {
                ConfigurarModoVendedor(idVendedor.Value);
            }
            else
            {
                ConfigurarModoGerente();
                
            }

            // Suscribir eventos de la vista
            this.view.SearchEvent += SearchVentas;
            this.view.GenerateReportEvent += GenerateReport;
            this.view.LimpiarFiltrosEvent += LimpiarFiltros;
            this.view.TipoReporteChangedEvent += TipoReporteChanged;
            // Configuración inicial
            ConfigurarFechasPorDefecto();

            this.view.Show();
        }

        private void ConfigurarModoVendedor(int idVendedor)
        {
            try
            {
                // Obtener datos del vendedor 
                var vendedor = repository.GetVendedorPorId(idVendedor);
                view.EsModoVendedor = true;  
                if (vendedor != null)
                {
                   // Configurar vista en modo vendedor
                    var vendedorUnico = new List<UsuarioModel> { vendedor };
                    view.ListaVendedores = vendedorUnico;               
                                      
                    view.ComboBusquedaHabilitado = false;
                    view.TipoReporte = "Por Vendedor";
                    

                    // Buscar automáticamente
                    SearchVentas(this, EventArgs.Empty);
                }
                else
                {
                    view.Message = "No se encontró el vendedor especificado";
                }
            }
            catch (Exception ex)
            {
                view.Message = $"Error al configurar modo vendedor: {ex.Message}";
            }
        }
        private void ConfigurarModoGerente()
        {
            try
            {
                view.ComboVendedorHabilitado = true;// Habilitar selección de vendedor
                // Cargar lista de vendedores
                var vendedores = repository.GetVendedoresActivos();
                view.ListaVendedores = vendedores.ToList();
                
                var clientes = repository.GetClientesActivos();
                view.ListaClientes = clientes.ToList();
                TipoReporteChanged(this, EventArgs.Empty);
                
            }
            catch (Exception ex)
            {
                view.Message = $"Error al cargar vendedores: {ex.Message}";
            }
        }
        private void ConfigurarFechasPorDefecto()
        {
            // Establecer fechas por defecto (mes actual)
            var fechaInicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var fechaFin = DateTime.Now;

            view.FechaInicio = fechaInicio;
            view.FechaFin = fechaFin;
            view.TotalVentas = "0.00";
            view.CantidadVentas = "0";
            view.PromedioVenta = "0.00";
           
        }
        private void TipoReporteChanged(object? sender, EventArgs e)
        {
            try
            {

                switch (view.TipoReporte)
                {
                    case "Por Vendedor":
                        var vendedores = repository.GetVendedoresActivos();
                        view.ListaVendedores = vendedores.ToList();                       
                        view.ComboBusquedaHabilitado = true;
                        break;

                    case "Por Cliente":
                        var clientes = repository.GetClientesActivos();
                        view.ListaClientes = clientes.ToList();                       
                        view.ComboBusquedaHabilitado = true;

                        break;

                    case "Por Fecha":
                        view.ComboBusquedaHabilitado = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                view.Message = $"Error al cargar datos: {ex.Message}";
            }
        }
        private void SearchVentas(object? sender, EventArgs e)
        {
            try
            {
                DateTime fechaInicio = view.FechaInicio;
                DateTime fechaFin = view.FechaFin;
                DateTime diaSiguiente = fechaFin.AddDays(1);
                DateTime fechaFinValorAjustado = diaSiguiente.AddMilliseconds(-3);
                //Validar fechas
                if (fechaInicio == DateTime.MinValue || fechaFinValorAjustado == DateTime.MinValue)
                {
                    view.Message = "Formato de fecha inválido. Use YYYY-MM-DD.";
                    view.IsSuccessful = false;
                    busquedaRealizada = false;
                    return;
                }

                if (fechaInicio > fechaFinValorAjustado)
                {
                    view.Message = "La fecha de inicio no puede ser mayor a la fecha fin.";
                    view.IsSuccessful = false;
                    busquedaRealizada = false;
                    return;
                }

                // Obtener datos según tipo de reporte
                switch (view.TipoReporte)
                {
                    case "Por Fecha":
                        ventasList = repository.GetVentasPorFecha(fechaInicio, fechaFinValorAjustado);
                        break;
                    case "Por Vendedor":                        
                        if (!view.IdVendedorSeleccionado.HasValue)
                        {
                            view.Message = "Debe seleccionar un vendedor para este tipo de reporte.";
                            return;
                        }
                        int idVendedor = view.IdVendedorSeleccionado.Value;
                        view.Message = $"Buscando ventas del vendedor ID: {idVendedor}";
                        ventasList = repository.GetVentasPorVendedor(idVendedor, fechaInicio, fechaFinValorAjustado);
                        break;

                    case "Por Cliente":
                        if (!view.IdClienteSeleccionado.HasValue)
                        {
                            view.Message = "Debe seleccionar un cliente.";
                            return;
                        }
                        int idCliente = view.IdClienteSeleccionado.Value;
                        ventasList = repository.GetVentasPorCliente(idCliente, fechaInicio, fechaFinValorAjustado);
                        break;
                    default:
                        ventasList = repository.GetVentasPorFecha(fechaInicio, fechaFinValorAjustado);
                       
                        break;
                }

                if (ventasList == null)
                {
                    ventasList = new List<VentaReporteModel>();
                }
                //  Calcular estadísticas
                CalcularEstadisticas(fechaInicio, fechaFinValorAjustado);

                //Enlazar datos a la vista
                ventasBindingSource.DataSource = ventasList;
                view.SetVentasListBindingSource(ventasBindingSource);

                view.Message = $"Se encontraron {ventasList.Count()} ventas en el período.";
                view.IsSuccessful = true;
                busquedaRealizada = true;
            }
            catch (Exception ex)
            {
                view.Message = $"Error al buscar ventas: {ex.Message}";
                view.IsSuccessful = false;
                busquedaRealizada = false;
            }
        }

        private void CalcularEstadisticas(DateTime fechaInicio, DateTime fechaFin)
        {
            decimal totalVentas;
            int cantidadVentas;

            // Diferenciar cálculo según tipo de reporte
            if (view.TipoReporte == "Por Vendedor" && view.IdVendedorSeleccionado.HasValue)
            {
                // Usar métodos específicos para vendedor
                totalVentas = repository.GetTotalVentasPorVendedor(
                    view.IdVendedorSeleccionado.Value, fechaInicio, fechaFin);
                cantidadVentas = repository.GetCantidadVentasPorVendedor(
                    view.IdVendedorSeleccionado.Value, fechaInicio, fechaFin);
            }else if (view.TipoReporte == "Por Cliente" && view.IdClienteSeleccionado.HasValue)
            {
                // Usar métodos específicos para cliente
                totalVentas = repository.GetTotalVentasPorCliente(
                    view.IdClienteSeleccionado.Value, fechaInicio, fechaFin);
                cantidadVentas = repository.GetCantidadVentasPorCliente(
                    view.IdClienteSeleccionado.Value, fechaInicio, fechaFin);
            }
            else
            {
                // Usar métodos generales
                totalVentas = repository.GetTotalVentasPeriodo(fechaInicio, fechaFin);
                cantidadVentas = repository.GetCantidadVentasPeriodo(fechaInicio, fechaFin);
            }

            decimal promedioVenta = cantidadVentas > 0 ? totalVentas / cantidadVentas : 0;

            view.TotalVentasPeriodo = totalVentas.ToString("C2");
            view.CantidadVentasPeriodo = cantidadVentas.ToString();
            view.PromedioVenta = promedioVenta.ToString("C2");
        }

        private void GenerateReport(object? sender, EventArgs e)
        {
            //Validar que se realizó búsqueda
            if (!busquedaRealizada)
            {
                view.Message = "Debe realizar primero una búsqueda antes de generar el reporte.";
                view.IsSuccessful = false;
                return;
            }

            var lista = (IEnumerable<VentaReporteModel>)ventasBindingSource.DataSource;

            if (lista == null || !lista.Any())
            {
                view.Message = "No hay datos para generar el reporte.";
                view.IsSuccessful = false;
                return;
            }

            string rutaPDF;
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar reporte de ventas";
                saveFileDialog.FileName = $"ReporteVentas_{DateTime.Now:yyyyMMdd_HHmm}.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaPDF = saveFileDialog.FileName;
                }
                else
                {
                    view.Message = "Generación de reporte cancelada.";
                    view.IsSuccessful = false;
                    return;
                }
            }

            //  Generar PDF
            var generador = new GeneradorPDFVentas();
            bool exito = generador.GenerarReporteVentas(lista, view, rutaPDF);

            view.Message = exito ? "Reporte de ventas generado correctamente." : "Error al generar el reporte.";
            view.IsSuccessful = exito;
        }

        private void LimpiarFiltros(object sender, EventArgs e)
        {
            try
            {
                //Limpiar la lista de ventas en memoria
                ventasList = null;
                busquedaRealizada = false;

                //Limpiar el BindingSource (datos del grid)
                ventasBindingSource.DataSource = null;

                // Resetear las fechas a valores por defecto
                ConfigurarFechasPorDefecto();

                //Limpiar estadísticas
                view.TotalVentas = "0.00";
                view.CantidadVentas = "0";
                view.PromedioVenta = "0.00";

                view.Message = "Filtros limpiados correctamente";
            }
            catch (Exception ex)
            {
                view.Message = $"Error al limpiar: {ex.Message}";
            }
        }
    }
}
