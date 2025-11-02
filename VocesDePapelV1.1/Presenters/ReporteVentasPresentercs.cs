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

        public ReporteVentasPresenter(IGerenteViewReporteVentas view, IVentaReporteRepository repository)
        {
            this.view = view;
            this.repository = repository;
            this.ventasBindingSource = new BindingSource();

            // Suscribir eventos de la vista
            this.view.SearchEvent += SearchVentas;
            this.view.GenerateReportEvent += GenerateReport;
            this.view.LimpiarFiltrosEvent += LimpiarFiltros;

            // Configuración inicial
            ConfigurarFechasPorDefecto();
            this.view.Show();
        }

        private void ConfigurarFechasPorDefecto()
        {
            // Establecer fechas por defecto (mes actual)
            var fechaInicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var fechaFin = DateTime.Now;

            view.FechaInicio = fechaInicio.ToString("yyyy-MM-dd");
            view.FechaFin = fechaFin.ToString("yyyy-MM-dd");
        }

        private void SearchVentas(object? sender, EventArgs e)
        {
            try
            {
                //Validar fechas
                if (!DateTime.TryParse(view.FechaInicio, out DateTime fechaInicio) ||
                    !DateTime.TryParse(view.FechaFin, out DateTime fechaFin))
                {
                    view.Message = "Formato de fecha inválido. Use YYYY-MM-DD.";
                    view.IsSuccessful = false;
                    busquedaRealizada = false;
                    return;
                }

                if (fechaInicio > fechaFin)
                {
                    view.Message = "La fecha de inicio no puede ser mayor a la fecha fin.";
                    view.IsSuccessful = false;
                    busquedaRealizada = false;
                    return;
                }

                // Obtener datos según tipo de reporte
                switch (view.TipoReporte)
                {
                    case "PorFecha":
                        ventasList = repository.GetVentasPorFecha(fechaInicio, fechaFin);
                        break;
                    case "PorVendedor":
                        if (int.TryParse(view.FiltroAdicional, out int idVendedor))
                            ventasList = repository.GetVentasPorVendedor(idVendedor);
                        else
                            ventasList = new List<VentaReporteModel>();
                        break;
                    case "Top10":
                        ventasList = repository.GetTop10Ventas();
                        break;
                    default:
                        ventasList = repository.GetVentasPorFecha(fechaInicio, fechaFin);
                        break;
                }

                //  Calcular estadísticas
                CalcularEstadisticas(fechaInicio, fechaFin);

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
            //Calcular métricas del reporte
            decimal totalVentas = repository.GetTotalVentasPeriodo(fechaInicio, fechaFin);
            int cantidadVentas = repository.GetCantidadVentasPeriodo(fechaInicio, fechaFin);
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
                // 1. Limpiar la lista de ventas en memoria
                ventasList = null;
                busquedaRealizada = false;

                // 2. Limpiar el BindingSource (datos del grid)
                ventasBindingSource.DataSource = null;

                // 3. Resetear las fechas a valores por defecto
                ConfigurarFechasPorDefecto();

                // 4. Limpiar estadísticas
                view.TotalVentas = "0.00";
                view.CantidadVentas = "0";
                view.PromedioVenta = "0.00";

                // 5. Opcional: Mostrar mensaje
                view.Message = "Filtros limpiados correctamente";
            }
            catch (Exception ex)
            {
                view.Message = $"Error al limpiar: {ex.Message}";
            }
        }
    }
}
