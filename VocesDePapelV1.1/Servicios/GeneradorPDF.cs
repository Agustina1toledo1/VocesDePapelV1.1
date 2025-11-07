using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Servicios
{
    public class GeneradorPDF
    {
        public bool GenerarReporteDesdeLista(IEnumerable<ProductoModel> productos, string rutaArchivo)//, int stockMinimo
        {
            try
            {
                Document doc = new Document(PageSize.A4, 25, 25, 30, 30);
                PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));
                doc.Open();

                // Cabecera con logo incrustado y fecha
                PdfPTable cabecera = new PdfPTable(2);
                cabecera.WidthPercentage = 100;
                cabecera.SetWidths(new float[] { 1f, 3f });

                // Convertir el recurso incrustado en imagen para iTextSharp
                using (var ms = new MemoryStream())
                {
                    Properties.Resources.logo.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    iTextSharp.text.Image logoPdf = iTextSharp.text.Image.GetInstance(ms.ToArray());
                    logoPdf.ScaleToFit(60f, 60f);
                    cabecera.AddCell(new PdfPCell(logoPdf) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                }
                
                PdfPCell celdaFecha = new PdfPCell(new Phrase(
                    $"Reporte de stock de libros \nGenerado el {DateTime.Now:dd/MM/yyyy HH:mm}",
                    FontFactory.GetFont("Arial", 12)))
                {
                    HorizontalAlignment = Element.ALIGN_RIGHT,
                    Border = iTextSharp.text.Rectangle.NO_BORDER
                };
                cabecera.AddCell(celdaFecha);

                doc.Add(cabecera);
                doc.Add(new Paragraph("\n"));

                // Tabla de datos
                PdfPTable tabla = new PdfPTable(5);
                tabla.WidthPercentage = 100;

                tabla.AddCell("Título");
                tabla.AddCell("Autor");
                tabla.AddCell("Editorial");
                tabla.AddCell("Precio");
                tabla.AddCell("Stock");

                foreach (var libro in productos)
                {
                    tabla.AddCell(libro.Titulo);
                    tabla.AddCell(libro.Nombre_autor);
                    tabla.AddCell(libro.Editorial);
                    tabla.AddCell(libro.Precio.ToString("C"));
                    tabla.AddCell(libro.Stock.ToString());
                }

                doc.Add(tabla);
                doc.Add(new Paragraph($"\nTotal de libros listados: {productos.Count()}",
                    FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD)));

                doc.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void GenerarComprobantePDF(VentaCabeceraModel2 cabecera, IEnumerable<VentaDetalleModel2> detalles, string rutaDestino)
        {
            try
            {
                using var fs = new FileStream(rutaDestino, FileMode.Create, FileAccess.Write, FileShare.None);
                var doc = new Document(PageSize.A4, 25, 25, 30, 30);
                PdfWriter.GetInstance(doc, fs);
                doc.Open();

                // 🔹 Cabecera con logo y fecha
                PdfPTable cabeceraTabla = new PdfPTable(2);
                cabeceraTabla.WidthPercentage = 100;
                cabeceraTabla.SetWidths(new float[] { 1f, 3f });

                using (var ms = new MemoryStream())
                {
                    Properties.Resources.logo.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    iTextSharp.text.Image logoPdf = iTextSharp.text.Image.GetInstance(ms.ToArray());
                    logoPdf.ScaleToFit(60f, 60f);
                    cabeceraTabla.AddCell(new PdfPCell(logoPdf) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                }

                var celdaTitulo = new PdfPCell(new Phrase(
                    $"Comprobante de Venta\nGenerado el {cabecera.Fecha_hora:dd/MM/yyyy HH:mm:ss}",
                    FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD)))
                {
                    HorizontalAlignment = Element.ALIGN_RIGHT,
                    Border = iTextSharp.text.Rectangle.NO_BORDER
                };
                cabeceraTabla.AddCell(celdaTitulo);

                doc.Add(cabeceraTabla);
                doc.Add(new Paragraph("\n"));

                // 🔹 Datos de la cabecera
                var fontLabel = FontFactory.GetFont("Arial", 11, iTextSharp.text.Font.BOLD);
                var fontValue = FontFactory.GetFont("Arial", 11);

                doc.Add(new Paragraph($"Nro de Comprobante: {cabecera.Id_venta_cabecera}", fontValue));
                doc.Add(new Paragraph($"Cliente: {cabecera.Nombre_cliente}", fontValue));
                doc.Add(new Paragraph($"Vendedor: {cabecera.Nombre_vendedor}", fontValue));
                doc.Add(new Paragraph($"Total: ${cabecera.Total_venta:F2}", fontValue));
                doc.Add(new Paragraph("\n"));

                // 🔹 Tabla de detalles
                PdfPTable tabla = new PdfPTable(4);
                tabla.WidthPercentage = 100;
                tabla.SetWidths(new float[] { 3f, 1f, 2f, 2f });

                var fontHeader = FontFactory.GetFont("Arial", 11, iTextSharp.text.Font.BOLD);
                tabla.AddCell(new Phrase("Libro", fontHeader));
                tabla.AddCell(new Phrase("Cantidad", fontHeader));
                tabla.AddCell(new Phrase("Precio Unitario", fontHeader));
                tabla.AddCell(new Phrase("Subtotal", fontHeader));

                int contador = 0;
                foreach (var d in detalles)
                {
                    tabla.AddCell(d.Titulo_libro);
                    tabla.AddCell(d.Cantidad.ToString());
                    tabla.AddCell($"${d.Precio_unitario:F2}");
                    tabla.AddCell($"${d.Subtotal:F2}");
                    contador++;
                }

                doc.Add(tabla);
                doc.Add(new Paragraph($"\nTotal de ítems: {contador}", fontValue));
                doc.Close();

                MessageBox.Show($"PDF generado correctamente:\n{rutaDestino}", "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}

