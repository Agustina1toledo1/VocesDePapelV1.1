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
    }
}

