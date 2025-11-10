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
    public class ReporteLibroMasVendidosPresenter
    {
      
        private IGerenteReporteLibroMasVendidos view;
        private IProductoRepository repository;
        private BindingSource productoFiltradoBildindSource;
        private IEnumerable<ProductoModel> productoFiltradoList;
        //private IEnumerable<ProductoModel> productosMasVendidosList;
        //atributo para controlar si se realizó una búsqueda para generar el reporte
        private bool busquedaRealizada = false;

        //constructor
        public  ReporteLibroMasVendidosPresenter(IGerenteReporteLibroMasVendidos view,
            IProductoRepository repository)
        {
            this.view = view;
            this.repository = repository;
            this.productoFiltradoBildindSource = new BindingSource();

            //eventos 
            this.view.GenerateReportEvent += GenerateReport;
            this.view.SearchEvent += SearchProductosFiltradosMV;
            //this.view.SetProductoFiltradoListBindingSource(productoFiltradoBildindSource);
            this.view.Show();
        }

        private void SearchProductosFiltradosMV(object? sender, EventArgs e)
        {
            try
            {
                DateTime fechaInicio = this.view.FechaInicio;
                DateTime fechaFin = this.view.FechaFin;

                // Ajustar fecha fin al último instante del día
                DateTime fechaFinValorAjustado = fechaFin.Date.AddDays(1).AddTicks(-1); //incluye el dia completo

                // Validar fechas
                if (fechaInicio == DateTime.MinValue || fechaFin == DateTime.MinValue)
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

                // Validar cantidad
                if (!int.TryParse(this.view.CantidaLibrosVendidos, out int cantTotal) || cantTotal <= 0)
                {
                    view.Message = "Ingrese un número válido para la cantidad mínima.";
                    view.IsSuccessful = false;
                    busquedaRealizada = false;
                    return;
                }

                // Consultar repositorio
                productoFiltradoList = repository.GetMasVendidos(fechaInicio, fechaFinValorAjustado, cantTotal);
                productoFiltradoBildindSource.DataSource = productoFiltradoList;
                this.view.SetLibroMasVendidoListBindingSource(productoFiltradoBildindSource);
                // categoría más vendida
                var categoriaMasVendida = repository.GetCategoriaMasVendida(fechaInicio, fechaFinValorAjustado);
                this.view.CategoriaMasVendidaLabel = $"{categoriaMasVendida.Categoria} ({categoriaMasVendida.TotalVendidos} unidades)";

                // total recaudado
                var totalRecaudado = repository.GetTotalRecaudado(fechaInicio, fechaFinValorAjustado);
                this.view.TotalRecaudadoLabel = $"${totalRecaudado:N2}";

                // Evaluar resultados
                if (!productoFiltradoList.Any())
                {
                    view.Message = "No se encontraron libros vendidos en ese rango de fechas.";
                    view.IsSuccessful = false;
                    busquedaRealizada = false;
                }
                else
                {
                    view.Message = $"Se encontraron {productoFiltradoList.Count()} libros más vendidos en el rango seleccionado.";
                    view.IsSuccessful = true;
                    busquedaRealizada = true;
                }
            }
            catch (Exception ex)
            {
                view.Message = $"Error al buscar ventas: {ex.Message}";
                view.IsSuccessful = false;
                busquedaRealizada = false;
            }
        }

        private void GenerateReport(object? sender, EventArgs e)
        {
            string rutaPDF;
            var generador = new GeneradorPDF();
            var lista = (IEnumerable<ProductoModel>)productoFiltradoBildindSource.DataSource;

            if (busquedaRealizada == false)
            {
                view.Message = "Debe realizar primero una búsqueda antes de generar el reporte.";
                view.IsSuccessful = false;
                return;
            }
            //verificar si hay datos para el reporte
            if (lista == null || !lista.Any())
            {
                view.Message = "No hay datos para generar el reporte.";
                view.IsSuccessful = false;
                return;
            }
            //el usuario elije la ruta de descarga
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar reporte como";
                saveFileDialog.FileName = "ReporteLibrosMasvendidos.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaPDF = saveFileDialog.FileName;
                    // acá llamás a tu GeneradorPDF con esa ruta
                }
                else
                {
                    view.Message = "Generación de reporte cancelada.";
                    view.IsSuccessful = false;
                    return;
                }
            }

            var categoriaMasVendida = repository.GetCategoriaMasVendida(view.FechaInicio, view.FechaFin);
            var totalRecaudado = repository.GetTotalRecaudado(view.FechaInicio, view.FechaFin);

            bool exito = generador.GenerarReporteDesdeLista(lista, rutaPDF, categoriaMasVendida.Categoria, 
                categoriaMasVendida.TotalVendidos, totalRecaudado);
            this.view.Message = exito ? "Reporte generado correctamente." : "Error al generar el reporte.";
            this.view.IsSuccessful = exito;
        }
    }
}
