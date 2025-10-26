using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Repositories;
using VocesDePapelV1._1.Views;

namespace VocesDePapelV1._1.Presenters
{
    public class ReporteProductoPresenter
    {
        private IGerenteReporteLibroStock view;
        private IProductoRepository repository;
        private BindingSource productoFiltradoBildindSource;
        private IEnumerable<ProductoModel> productoFiltradoList;

        //constructor
        public ReporteProductoPresenter(IGerenteReporteLibroStock view, IProductoRepository repository)
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

           /* if (!int.TryParse(this.view.StockMinimo, out int stockMinimo) || stockMinimo < 0)
            {
                this.view.Message = "Ingrese un número válido para el stock mínimo.";
                this.view.IsSuccessful = false;
                return;
            }
            var librosFiltrados = repository.GetByStockMenorOIgual(stockMinimo);
            productoFiltradoBildindSource.DataSource = librosFiltrados;

            if (!librosFiltrados.Any())
            {
                this.view.Message = "No se encontraron libros con ese stock.";
                this.view.IsSuccessful = false;
            }
            else
            {
                this.view.Message = $"Se encontraron {librosFiltrados.Count()} libros con stock ≤ {stockMinimo}.";
                this.view.IsSuccessful = true;
            }*/
            
            bool emptyValue = string.IsNullOrEmpty(view.StockMinimo);

            if(emptyValue == false)
            {
                productoFiltradoList = repository.GetByStockMenorOIgual(int.Parse(view.StockMinimo));
                productoFiltradoBildindSource.DataSource = productoFiltradoList;
                this.view.SetProductoFiltradoListBindingSource(productoFiltradoBildindSource);
            }
            else
            {
                this.view.Message = "El campo no puede estar vacio";
            }

        }

        private void GenerateReport(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
