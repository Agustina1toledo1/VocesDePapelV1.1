using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Views;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Servicios;
using System.Windows.Forms;
using VocesDePapelV1._1.Repositories;

namespace VocesDePapelV1._1.Presenters
{
    public class AdministradorPresenter
    {
        private IAdministradorView view;
        //un campo de solo lectura para la cadena de conexion
        private readonly string connectionString;
        private ProductoPresenter productoPresenter; //para no repetir instancias de venta
        private AutoresAdminPresenter autorPresenter;
        private CategoriaAmdinPresenter categoriaPresenter;
        private ReporteProductoPresenter reporteProductoPresenter;
        private ReporteLibroMasVendidosPresenter reporteLibroMasVendidosPresenter;
        private ReporteVentasPresenter reportePresenter;
        public AdministradorPresenter(IAdministradorView view, string connectionString)
        {
            this.view = view;
            this.connectionString = connectionString;

            //suscribirse a los eventos de la vista
            this.view.ShowProductoView += ShowProductoView;
            this.view.ShowReporteVentaView += ShowReporteVentaView;
            this.view.ShowReporteLibroStockView += ShowReporteLibroStockView;
            this.view.ShowReporteLibroMasVendidosView += ShowReporteLibroMasVendidosView;
            this.view.ShowAutoresView += ShowAutoresView;
            this.view.ShowCategoriasView += ShowCategoriasView;
            this.view.LogoutEvent += LogoutEvent;
        }

        private void LogoutEvent(object? sender, EventArgs e)
        {

            //view.Ocultar(); // Oculta la vista actual
            //Program.IniciarAplicacion(); // Volvés al login
            view.Cerrar(); // Cerrás la vista actual después de que el login termine
        }

        private void ShowCategoriasView(object? sender, EventArgs e)
        {
            
            IAdministradorCategoria backupView = AdministradorViewCategorias.GetInstance((AdministradorView)this.view); // muestra solo una instancia de la vista de usuario
            if(categoriaPresenter == null)
            {
                ICategoriaRepository repository = new CategoriaRepository(connectionString);
                categoriaPresenter = new CategoriaAmdinPresenter(backupView, repository);
            }
        }

        private void ShowAutoresView(object? sender, EventArgs e)
        {
            IAdministradorAutor backupView = AdministradorViewAutores.GetInstance((AdministradorView)this.view); // muestra solo una instancia de la vista de usuario
            if(autorPresenter == null)
            {
                IAutorRepository repository = new AutorRepository(connectionString);
                autorPresenter = new AutoresAdminPresenter(backupView, repository);
            }
            
        }

        private void ShowReporteLibroMasVendidosView(object? sender, EventArgs e)
        {
            IGerenteReporteLibroMasVendidos view = GerenteViewReporteLibroMasVendidos.GetInstance((AdministradorView)this.view); // muestra solo una instancia de la vista de usuario

            if (reporteLibroMasVendidosPresenter == null)
            {
                IProductoRepository repository = new ProductoRepository(connectionString);
                reporteLibroMasVendidosPresenter = new ReporteLibroMasVendidosPresenter(view, repository);
            }

        }

        //como el reporte de stock y mas vendidos de libro y reporte de venta son iguales en la vista del gerente

        private void ShowReporteLibroStockView(object? sender, EventArgs e)
        {
            IGerenteReporteLibroStock view = GerenteViewReporteLibroStock.GetInstance((AdministradorView)this.view); // muestra solo una instancia de la vista de usuario
            
            if (reporteProductoPresenter == null)
            {
                IProductoRepository repository = new ProductoRepository(connectionString);
                reporteProductoPresenter =new ReporteProductoPresenter(view,  repository);
            }
            
        }

        private void ShowReporteVentaView(object? sender, EventArgs e)
        {
            IGerenteViewReporteVentas reporteView = ReporteVentasView.GetInstance((AdministradorView)this.view);
            if(reportePresenter == null)
            {
                IVentaReporteRepository repository = new VentaReporteRepository(connectionString);
                reportePresenter =new ReporteVentasPresenter(reporteView, repository, false, null);
            }
            
        }

        private void ShowProductoView(object? sender, EventArgs e)
        {
            IAdministradorViewProducto view = AdministradorViewProducto.GetInstance((AdministradorView)this.view); // muestra solo una instancia de la vista de usuario
            
            if(productoPresenter == null)
            {
                IProductoRepository repository = new ProductoRepository(connectionString);
                productoPresenter = new ProductoPresenter(view, repository);
            }
            
        }
    }
}
