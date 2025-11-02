using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using VocesDePapelV1._1.Models;
using VocesDePapelV1._1.Views;
using VocesDePapelV1._1.Properties;

namespace VocesDePapelV1._1.Servicios
{
    public class GeneradorPDFVentas
    {
        public bool GenerarReporteVentas(IEnumerable<VentaReporteModel> ventas, IGerenteViewReporteVentas view, string rutaArchivo)
        {
            try
            {
                // Crear documento PDF
                Document doc = new Document(PageSize.A4.Rotate(), 25, 25, 30, 30);
                PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));
                doc.Open();

                // Cabecera
                PdfPTable cabecera = new PdfPTable(2);
                cabecera.WidthPercentage = 100;
                cabecera.SetWidths(new float[] { 1f, 3f });

                // Logo
                using (var ms = new MemoryStream())
                {
                    Properties.Resources.logo.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    iTextSharp.text.Image logoPdf = iTextSharp.text.Image.GetInstance(ms.ToArray());
                    logoPdf.ScaleToFit(60f, 60f);
                    cabecera.AddCell(new PdfPCell(logoPdf) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                }

                // Información del reporte
                string infoReporte = $"REPORTE DE VENTAS\n" +
                                   $"Período: {view.FechaInicio} al {view.FechaFin}\n" +
                                   $"Total Ventas: {view.TotalVentasPeriodo}\n" +
                                   $"Cantidad: {view.CantidadVentasPeriodo} ventas\n" +
                                   $"Promedio: {view.PromedioVenta} por venta\n" +
                                   $"Generado: {DateTime.Now:dd/MM/yyyy HH:mm}";

                PdfPCell celdaInfo = new PdfPCell(new Phrase(infoReporte,
                    FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD)))
                {
                    HorizontalAlignment = Element.ALIGN_RIGHT,
                    Border = iTextSharp.text.Rectangle.NO_BORDER
                };
                cabecera.AddCell(celdaInfo);

                doc.Add(cabecera);
                doc.Add(new Paragraph("\n"));

                //Tabla de ventas
                PdfPTable tabla = new PdfPTable(8);
                tabla.WidthPercentage = 100;
                tabla.SetWidths(new float[] { 0.8f, 1.2f, 2f, 2f, 1.2f, 1f, 1f, 1f });

                // Encabezados
                tabla.AddCell(CrearCeldaEncabezado("N° Factura"));
                tabla.AddCell(CrearCeldaEncabezado("Fecha"));
                tabla.AddCell(CrearCeldaEncabezado("Cliente"));
                tabla.AddCell(CrearCeldaEncabezado("Vendedor"));
                tabla.AddCell(CrearCeldaEncabezado("Total"));
                tabla.AddCell(CrearCeldaEncabezado("Estado"));
                tabla.AddCell(CrearCeldaEncabezado("Productos"));
                tabla.AddCell(CrearCeldaEncabezado("Pago"));

                // Datos de ventas
                foreach (var venta in ventas)
                {
                    tabla.AddCell(CrearCeldaDato(venta.IdVenta.ToString()));
                    tabla.AddCell(CrearCeldaDato(venta.FechaVenta.ToString("dd/MM/yyyy")));
                    tabla.AddCell(CrearCeldaDato(venta.NombreCliente));
                    tabla.AddCell(CrearCeldaDato(venta.NombreVendedor));
                    tabla.AddCell(CrearCeldaDato(venta.TotalVenta.ToString("C2")));
                    tabla.AddCell(CrearCeldaDato(venta.EstadoVenta));
                    tabla.AddCell(CrearCeldaDato(venta.CantidadProductos.ToString()));
                   
                }

                doc.Add(tabla);

                // Resumen final
                doc.Add(new Paragraph($"\nResumen del Reporte:",
                    FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD)));

                string resumen = $"• Total de ventas en período: {view.TotalVentasPeriodo}\n" +
                               $"• Cantidad de ventas: {view.CantidadVentasPeriodo}\n" +
                               $"• Promedio por venta: {view.PromedioVenta}\n" +
                               $"• Ventas listadas: {ventas.Count()}";

                doc.Add(new Paragraph(resumen,
                    FontFactory.GetFont("Arial", 10)));

                doc.Close();
                return true;
            }
            catch (Exception ex)
            {
                // En una aplicación real, deberías loggear este error
                return false;
            }
        }

        private PdfPCell CrearCeldaEncabezado(string texto)
        {
            return new PdfPCell(new Phrase(texto,
                FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD)))
            {
                BackgroundColor = BaseColor.LIGHT_GRAY,
                HorizontalAlignment = Element.ALIGN_CENTER,
                Padding = 5
            };
        }

        private PdfPCell CrearCeldaDato(string texto)
        {
            return new PdfPCell(new Phrase(texto,
                FontFactory.GetFont("Arial", 9)))
            {
                Padding = 4
            };
        }
    }
}
