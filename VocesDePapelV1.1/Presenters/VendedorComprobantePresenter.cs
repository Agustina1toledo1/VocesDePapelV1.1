using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Views;
using VocesDePapelV1._1.Repositories;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Presenters
{
    public class VendedorComprobantePresenter
    {
        private IVendedorComprobanteView view;
        private IVentaCabeceraRepository2 cabeceraRepository;
        private IVentaDetalleRepository2 detalleRepository;
        private BindingSource bindingSourceCabecera;
        private BindingSource bindingSourceDetalle;
        private IEnumerable<VentaCabeceraModel2> ventaCabecerasList;
        private IEnumerable<VentaDetalleModel2> ventaDetallesList;

        public VendedorComprobantePresenter(IVendedorComprobanteView view,
            IVentaCabeceraRepository2 cabeceraRepository, 
            IVentaDetalleRepository2 detalleRepository)
        {
            //inicializamos los campos
            this.view = view;
            this.cabeceraRepository = cabeceraRepository;
            this.detalleRepository = detalleRepository;
            this.bindingSourceCabecera = new BindingSource();
            this.bindingSourceDetalle = new BindingSource();

            //suscribimos a eventos de la vista
            this.view.SearchComprobanteEvent += SearchComprobante;
            this.view.GenerarPDFEvent += GenerarPDFComprobante;
            this.view.LoadEvent += LoadDetalleVenta;

            //cargar los datos
            CargarAllCabeceras();
            CargarAllDetalles();
            //enlazamos los datos
            this.view.SetComprobanteListBindingSource(bindingSourceCabecera);
            this.view.SetComprobanteDetalleListBindingSource(bindingSourceDetalle);

            //mostramos la vista
            this.view.Show();

        }

        private void LoadDetalleVenta(object? sender, EventArgs e)
        {
            var cabeceraVenta = (VentaCabeceraModel2)bindingSourceCabecera.Current;
            int idVentaCabecera = cabeceraVenta.Id_venta_cabecera;

            ventaDetallesList = detalleRepository.GetByVentaId(idVentaCabecera);
            bindingSourceDetalle.DataSource = ventaDetallesList;
            this.view.SetComprobanteDetalleListBindingSource(bindingSourceDetalle);
        }

        private void CargarAllDetalles()
        {
            ventaDetallesList = detalleRepository.GetAll();
            bindingSourceDetalle.DataSource = ventaDetallesList;
        }

        private void CargarAllCabeceras()
        {
            ventaCabecerasList = cabeceraRepository.GetAll();
            bindingSourceCabecera.DataSource = ventaCabecerasList;

        }

        private void GenerarPDFComprobante(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchComprobante(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchNumeroComprobante);
            if(emptyValue == false)
            {
                ventaCabecerasList = cabeceraRepository.GetById(Convert.ToInt32(this.view.SearchNumeroComprobante));

            }
            else
            {
                ventaCabecerasList = cabeceraRepository.GetAll();
            }
            bindingSourceCabecera.DataSource = ventaCabecerasList;
        }
    }
}
