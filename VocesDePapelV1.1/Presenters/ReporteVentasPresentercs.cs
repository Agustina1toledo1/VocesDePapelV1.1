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
        private IEnumerable<VentaCabeceraModel> ventasList;
        private bool busquedaRealizada = false;

<<<<<<< HEAD
        public ReporteVentasPresenter(IGerenteViewReporteVentas view, IVentaReporteRepository repository,
                                  bool esModoVendedor = false, int? idVendedor = null)
        {            
=======
        public ReporteVentasPresenter(IGerenteViewReporteVentas view, IVentaReporteRepository repository, bool esModoVendedor = false,
                                  int? idVendedor = null)
        {
            Console.WriteLine($"MODO VENDEDOR: {esModoVendedor}, ID: {idVendedor}");

            this.view = view;
            this.repository = repository;

            // DEBUG TEMPORAL
            view.Message = $"Modo: {(esModoVendedor ? "VENDEDOR" : "GERENTE")}, ID: {idVendedor}";

>>>>>>> se agrega acceso a reporte de ventas para vendedor con  filtro restringido
            this.view = view;
            this.repository = repository;
            this.ventasBindingSource = new BindingSource();
            ConfigurarFechasPorDefecto();
            // Configurar modo de la vista
<<<<<<< HEAD
            if (esModoVendedor && idVendedor.HasValue)
            {
=======
            view.EsModoVendedor = esModoVendedor;

            if (esModoVendedor && idVendedor.HasValue)
            {
                view.IdVendedorAutomatico = idVendedor.Value;
>>>>>>> se agrega acceso a reporte de ventas para vendedor con  filtro restringido
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
                       

            this.view.Show();
        }

        private void ConfigurarModoVendedor(int idVendedor)
        {
            try
            {
<<<<<<< HEAD
                // Obtener datos del vendedor 
=======
                // Obtener datos del vendedor (CORREGIDO el nombre del método)
>>>>>>> se agrega acceso a reporte de ventas para vendedor con  filtro restringido
                var vendedor = repository.GetVendedorPorId(idVendedor);

                if (vendedor != null)
                {
<<<<<<< HEAD
                    // Configurar vista en modo vendedor
                    var vendedorUnico = new List<UsuarioModel> { vendedor };
                    view.ListaVendedores = vendedorUnico;
                    //view.VendedorSeleccionadoId = idVendedor; // Seleccionar automáticamente
                    view.IdVendedorSeleccionado = idVendedor;
                    view.TextoVendedor = $"{vendedor.Nombre} {vendedor.Apellido}";// Mostrar nombre
                    view.ComboVendedorHabilitado = false;// Deshabilitar selección
                    view.TipoReporte = "Por Vendedor";// Forzar tipo de reporte
                    view.TextoBusqueda = $"{vendedor.Nombre} {vendedor.Apellido}";
                    view.ComboBusquedaHabilitado = false;
                    view.DatosComboBusqueda = vendedorUnico; view.TipoReporte = "Por Vendedor";
                    view.EtiquetaBusqueda = "Vendedor:";
=======
                    view.TxtVendedorAuto = $"{vendedor.Nombre} {vendedor.Apellido}";
                    view.IdVendedorSeleccionado = idVendedor;

                    // Bloquear selección de vendedor
                    view.FiltroVendedorVisible = true;
                    view.TipoReporte = "Por Vendedor";
                    view.CmbTipoReporteEnabled = false; // Bloquear cambio de tipo reporte

>>>>>>> se agrega acceso a reporte de ventas para vendedor con  filtro restringido
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
<<<<<<< HEAD
            try
            {
                view.ComboVendedorHabilitado = true;// Habilitar selección de vendedor
                // Cargar lista de vendedores
                var vendedores = repository.GetVendedoresActivos();
                view.ListaVendedores = vendedores.ToList();
                TipoReporteChanged(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                view.Message = $"Error al cargar vendedores: {ex.Message}";
            }
=======
            // Cargar lista de vendedores
            var vendedores = repository.GetVendedoresActivos();
            view.ListaVendedores = vendedores.ToList();
            view.CmbTipoReporteEnabled = true; // Permitir cambiar tipo reporte
>>>>>>> se agrega acceso a reporte de ventas para vendedor con  filtro restringido
        }
        private void ConfigurarFechasPorDefecto()
        {
            // Establecer fechas por defecto (mes actual)
            var fechaInicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var fechaFin = DateTime.Now;

            view.FechaInicio = fechaInicio.ToString("yyyy-MM-dd");
            view.FechaFin = fechaFin.ToString("yyyy-MM-dd");
            view.TipoReporte = "Por Fecha";
            view.IncluirDetalles = false;

        }
        private void TipoReporteChanged(object? sender, EventArgs e)
        {
            try
            {

                switch (view.TipoReporte)
                {
                    case "Por Vendedor":
                        /*var vendedores = repository.GetVendedoresActivos();
                        view.ListaVendedores = vendedores.ToList();
                        view.EtiquetaBusqueda = "Seleccionar Vendedor:";
                        view.ComboBusquedaHabilitado = true;*/
                        var vendedores = repository.GetVendedoresActivos();
                        view.ListaVendedores = vendedores.ToList();
                        view.DatosComboBusqueda = vendedores.ToList();
                        view.EtiquetaBusqueda = "Seleccionar Vendedor:";
                        view.ComboBusquedaHabilitado = true;
                        view.TextoBusqueda = string.Empty; // Limpiar selección
                        break;
                        break;

                    case "Por Cliente":
                        var clientes = repository.GetClientesActivos();
                        view.ListaClientes = clientes.ToList();
                        view.EtiquetaBusqueda = "Seleccionar Cliente:";
                        view.ComboBusquedaHabilitado = true;
                        break;

                    case "Por Fecha":
                    case "Top 10 Ventas":
                        view.EtiquetaBusqueda = "Búsqueda:";
                        view.ComboBusquedaHabilitado = false;
                        view.TextoBusqueda = string.Empty;
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
                    case "Por Fecha":
                        ventasList = repository.GetVentasPorFecha(fechaInicio, fechaFin);
                        break;
                    case "Por Vendedor":
<<<<<<< HEAD
                        if (!view.IdVendedorSeleccionado.HasValue)
                        {
                            view.Message = "Debe seleccionar un vendedor.";
                            return;
                        }
                        ventasList = repository.GetVentasPorVendedor(
                            view.IdVendedorSeleccionado.Value, fechaInicio, fechaFin);
                        break;

                    /*case "Top 10 Ventas":
                        
                        ventasList = repository.GetVentaCabecera()
                            .OrderByDescending(v => v.Total)
                            .Take(10)
                            .ToList();
                        break;
                    default:
                        ventasList = repository.GetVentasPorFecha(fechaInicio, fechaFin);
                        break;
                }

                if (ventasList == null)
                {
                    ventasList = new List<VentaCabeceraModel>();
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

            var lista = (IEnumerable<VentaCabeceraModel>)ventasBindingSource.DataSource;

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
