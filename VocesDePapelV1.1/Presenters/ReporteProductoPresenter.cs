using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Repositories;
using VocesDePapelV1._1.Servicios;
using VocesDePapelV1._1.Views;
using System.Drawing;

namespace VocesDePapelV1._1.Presenters
{
    public class ReporteProductoPresenter
    {
        private IGerenteReporteLibroStock view;
        private IProductoRepository repository;
        private BindingSource productoFiltradoBildindSource;
        private IEnumerable<ProductoModel> productoFiltradoList;
        //atributo para controlar si se realizó una búsqueda para generar el reporte
        private bool busquedaRealizada = false;

        //constructor
        public ReporteProductoPresenter(IGerenteReporteLibroStock view, 
            IProductoRepository repository)
        {
            this.view = view;
            this.repository = repository;
            this.productoFiltradoBildindSource = new BindingSource();

            //eventos 
            this.view.GenerateReportEvent += GenerateReport;
            this.view.SearchEvent += SearchProductosFiltrados;

            //this.view.SetProductoFiltradoListBindingSource(productoFiltradoBildindSource);
            this.view.Show();
        }

        private void SearchProductosFiltrados(object? sender, EventArgs e)
        {

             if (!int.TryParse(this.view.StockMinimo, out int stockMinimo) || stockMinimo < 0)
             {
                 this.view.Message = "Ingrese un número válido para el stock mínimo.";
                 this.view.IsSuccessful = false;
                busquedaRealizada = false;
                return;
             }
             productoFiltradoList = repository.GetByStockMenorOIgual(int.Parse(view.StockMinimo));
                 productoFiltradoBildindSource.DataSource = productoFiltradoList;
                 this.view.SetProductoFiltradoListBindingSource(productoFiltradoBildindSource);

             /*if (!productoFiltradoList.Any())
             {
                 this.view.Message = "No se encontraron libros con ese stock.";
                 this.view.IsSuccessful = false;
                busquedaRealizada = false;
            }*/
             
                 this.view.Message = $"Se encontraron {productoFiltradoList.Count()} libros con stock ≤ {stockMinimo}.";
                 this.view.IsSuccessful = true;
                busquedaRealizada = true;//marca que se realizó una búsqueda exitosa
            
        }

        private void GenerateReport(object? sender, EventArgs e)
        {
            string rutaPDF;
            var generador = new GeneradorPDF();
            var lista = (IEnumerable<ProductoModel>)productoFiltradoBildindSource.DataSource;

            if (busquedaRealizada== false)
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
                saveFileDialog.FileName = "ReporteLibros.pdf";

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

            bool exito = generador.GenerarReporteDesdeLista(lista, rutaPDF);
            view.Message = exito ? "Reporte generado correctamente." : "Error al generar el reporte.";
            view.IsSuccessful = exito;
        }
    }
}
