using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Views;

namespace VocesDePapelV1._1.Presenters
{
    public class ReporteLibroStockPresenter
    {
        //campos        
        private IGerenteReporteLibroStock view; //campo privado para la vista usando la interfaz
        private IGerenteReporteLibroStock repository;
        private BindingSource productoBindingSource; //origen de datos para el enlace
        private IEnumerable<ProductoModel> productoList; //lista de productos
        //constructor
        public ReporteLibroStockPresenter(IGerenteReporteLibroStock view, IGerenteReporteLibroStock repository)
        {
            this.productoBindingSource = new BindingSource();
            this.repository = repository;
            this.view = view;

            this.view.SearchEvent += SearchProducto;
            this.view.GenerateReportEvent += GenerateReport;

            //mostramos la vista
            this.view.Show();
        }

       
    }
}
