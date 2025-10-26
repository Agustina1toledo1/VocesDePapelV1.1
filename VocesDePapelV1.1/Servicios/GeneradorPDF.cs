using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Windows.Forms;

namespace VocesDePapelV1._1.Servicios
{
    public class GeneradorPDF
    {
        public bool GenerarReporteDesdeGrid(DataGridView dgv, string rutaArchivo, string rutaLogo)
        {
            try
            {
                Document doc = new Document(PageSize.A4, 25, 25, 30, 30);
                PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));
                doc.Open();

                // Cabecera con logo y fecha
                PdfPTable cabecera = new PdfPTable(2);
                cabecera.WidthPercentage = 100;
                cabecera.SetWidths(new float[] { 1f, 3f });

                if (File.Exists(rutaLogo))
                {
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(rutaLogo);
                    logo.ScaleToFit(60f, 60f);
                    PdfPCell celdaLogo = new PdfPCell(logo) { Border = iTextSharp.text.Rectangle.NO_BORDER };
                    cabecera.AddCell(celdaLogo);
                }
                else
                {
                    cabecera.AddCell(new PdfPCell(new Phrase("Logo no disponible")) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                }

                PdfPCell celdaFecha = new PdfPCell(new Phrase($"Reporte generado el {DateTime.Now:dd/MM/yyyy HH:mm}", FontFactory.GetFont("Arial", 12)))
                {
                    HorizontalAlignment = Element.ALIGN_RIGHT,
                    Border = iTextSharp.text.Rectangle.NO_BORDER
                };
                cabecera.AddCell(celdaFecha);
                doc.Add(cabecera);

                doc.Add(new Paragraph("\n"));

                // Tabla de datos
                PdfPTable tabla = new PdfPTable(dgv.Columns.Count);
                tabla.WidthPercentage = 100;

                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    tabla.AddCell(new Phrase(col.HeaderText, FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD)));
                }

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            tabla.AddCell(new Phrase(cell.Value?.ToString() ?? "", FontFactory.GetFont("Arial", 10)));
                        }
                    }
                }

                doc.Add(tabla);
                doc.Add(new Paragraph($"\nTotal de libros: {dgv.Rows.Count - 1}", FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD)));

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
