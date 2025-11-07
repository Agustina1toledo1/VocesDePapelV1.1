using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Views;
using VocesDePapelV1._1.Repositories;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Servicios;

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
            var cabeceraVenta = bindingSourceCabecera.Current as VentaCabeceraModel2;

            if (cabeceraVenta == null)
            {
                // No hay cabecera seleccionada → vaciar detalles
                bindingSourceDetalle.DataSource = null;
                view.SetComprobanteDetalleListBindingSource(bindingSourceDetalle);
                return;
            }

            int idVentaCabecera = cabeceraVenta.Id_venta_cabecera;
            ventaDetallesList = detalleRepository.GetByVentaId(idVentaCabecera);

            bindingSourceDetalle.DataSource = ventaDetallesList;
            view.SetComprobanteDetalleListBindingSource(bindingSourceDetalle);
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
            string rutaPDF;
            var generador = new GeneradorPDF();
            var detallelista = ((IEnumerable<VentaDetalleModel2>)bindingSourceDetalle.DataSource);
            var cabeceraVenta = (VentaCabeceraModel2)bindingSourceCabecera.Current;

            if (cabeceraVenta == null)
            {
                MessageBox.Show("Debe seleccionar una venta");
                return;
            }
            else
            {
                //el usuario elije la ruta de descarga
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Guardar reporte como";
                    saveFileDialog.FileName = "ComprobanteNro"+ cabeceraVenta.Id_venta_cabecera;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        rutaPDF = saveFileDialog.FileName;
                        // acá llamás a tu GeneradorPDF con esa ruta
                    }
                    else
                    {
                        view.IsSuccessful = false;
                        return;
                    }
                }
                generador.GenerarComprobantePDF(cabeceraVenta, detallelista, rutaPDF);
            }
        }

        private void SearchComprobante(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchNumeroComprobante);

            if (!emptyValue)
            {
                ventaCabecerasList = cabeceraRepository.GetById(Convert.ToInt32(this.view.SearchNumeroComprobante));

                // 🔹 Si no se encontró la cabecera, vaciar detalles
                if (ventaCabecerasList == null || !ventaCabecerasList.Any())
                {
                    MessageBox.Show("No existe el comprobante.");
                    bindingSourceCabecera.DataSource = null;
                    bindingSourceDetalle.DataSource = null;
                    view.SetComprobanteDetalleListBindingSource(bindingSourceDetalle);
                    return;
                }
            }
            else
            {
                
                ventaCabecerasList = cabeceraRepository.GetAll();
            }

            bindingSourceCabecera.DataSource = ventaCabecerasList;
        }

    }
}
