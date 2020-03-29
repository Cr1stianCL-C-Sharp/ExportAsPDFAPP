using ExportAsPDF.PDFHelpers;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;

namespace ExportAsPDF.PDFGenerator
{
    public class PDFTemplate
    {

        public void CreatePDF()
        {
            try
            {

                //var directory = Directory.GetCurrentDirectory();
                //string startupPath = System.IO.Path.GetFullPath(".\\");
                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
                string fileName = string.Format("{0}_{1}", (DateTime.Now).ToString("ddMMyyyy_HHmmss"), "exported.pdf");
                var templateRoute = "PDFTemplate";
                var tRoute = string.Format("{0}\\{1}\\{2}", projectDirectory, templateRoute, fileName);
                var imgRoute = "LOGO/LOGO_SAG.png";
                var iRoute = string.Format("{0}\\{1}", projectDirectory, imgRoute);

                ///--->crea y guarda el archivo
                Document pdfDocument = new Document();
                PdfWriter.GetInstance(pdfDocument,
                    new FileStream(tRoute, FileMode.Create));

                ///-->abre el documento
                pdfDocument.Open();

                //PdfPTable imgTabla = new PdfPTable(1);
                ////---> agrega imagen
                ImageHelper helper = new ImageHelper();
                var img = helper.ReziseImg(iRoute);
                img.Alignment = Image.TEXTWRAP | Image.ALIGN_LEFT;
                img.IndentationLeft = 9f;
                img.SpacingAfter = 9f;
                img.BorderWidthTop = 36f;
                img.BorderColorTop = BaseColor.WHITE;

                pdfDocument.Add(img);

                var titulo1 = new
                    Paragraph(
                        new Chunk(@"PROGRAMA OFICIAL DE TRAZABILIDAD ANIMAL"));
                var titulo2 = new
                    Paragraph(
                        new Chunk(@"DECLARACIÓN DE EXISTENCIAS DE ANIMALES"));
                var titulo3 = new
                    Paragraph(
                        new Chunk(@"CERTIFICADO ELECTRÓNICO DE DECLARACIÓN"));
                //titulo1.PaddingTop = 40;
                titulo1.Alignment = Element.ALIGN_RIGHT;
                titulo1.SpacingAfter = 5;
                titulo1.IndentationRight = 102f;
                titulo2.Alignment = Element.ALIGN_RIGHT;
                titulo2.SpacingAfter = 5;
                titulo2.IndentationRight = 106f;
                titulo3.Alignment = Element.ALIGN_RIGHT;
                titulo3.SpacingAfter = 5;
                titulo3.IndentationRight = 99f;


                pdfDocument.Add(titulo1);
                pdfDocument.Add(titulo2);
                pdfDocument.Add(titulo3);

                pdfDocument.Add(new Paragraph("\n"));
                pdfDocument.Add(new Paragraph("\n"));
                pdfDocument.Add(new Paragraph("\n"));

                PdfPTable tablaCabecera = new PdfPTable(4);
                //tablaCabecera.PaddingTop = 100;
                PdfPCell datoCabecera1 = new PdfPCell(new Phrase("RUP:"));
                PdfPCell dato1 = new PdfPCell(new Phrase("10.189.523.2"));
                PdfPCell datoCabecera2 = new PdfPCell(new Phrase("FECHA DE DECLARACIÓN:"));
                PdfPCell dato2 = new PdfPCell(new Phrase("26/08/2016"));
                PdfPCell datoCabecera3 = new PdfPCell(new Phrase("NOMBRE:"));
                PdfPCell dato3 = new PdfPCell(new Phrase("LA MOSQUETA"));
                PdfPCell datoCabecera4 = new PdfPCell(new Phrase("AÑO DE DECLARACIÓN:"));
                PdfPCell dato4 = new PdfPCell(new Phrase("2016"));
                PdfPCell datoCabecera5 = new PdfPCell(new Phrase("COMUNA:"));
                PdfPCell dato5 = new PdfPCell(new Phrase("PUYEHUE"));
                PdfPCell datoCabecera6 = new PdfPCell(new Phrase("TIPO DE DECLARACIÓN:"));
                PdfPCell dato6 = new PdfPCell(new Phrase("ANUAL"));
                PdfPCell datoCabecera7 = new PdfPCell(new Phrase("FECHA DE REGISTRO EN SISTEMA:"));
                PdfPCell dato7 = new PdfPCell(new Phrase("28/08/2016"));

                datoCabecera1.UseVariableBorders = true;
                datoCabecera1.Border = 0;
                tablaCabecera.AddCell(datoCabecera1);
                ////////////////////////////////////////////////
                dato1.UseVariableBorders = true;
                dato1.Border = 0;
                tablaCabecera.AddCell(dato1);
                ////////////////////////////////////////////////
                datoCabecera2.UseVariableBorders = true;
                datoCabecera2.Border = 0;
                tablaCabecera.AddCell(datoCabecera2);
                ////////////////////////////////////////////////
                dato2.UseVariableBorders = true;
                dato2.Border = 0;
                tablaCabecera.AddCell(dato2);
                ////////////////////////////////////////////////
                datoCabecera3.UseVariableBorders = true;
                datoCabecera3.Border = 0;
                tablaCabecera.AddCell(datoCabecera3);
                ////////////////////////////////////////////////
                dato3.UseVariableBorders = true;
                dato3.Border = 0;
                tablaCabecera.AddCell(dato3);

                ////////////////////////////////////////////////
                datoCabecera4.UseVariableBorders = true;
                datoCabecera4.Border = 0;
                tablaCabecera.AddCell(datoCabecera4);
                ////////////////////////////////////////////////
                dato4.UseVariableBorders = true;
                dato4.Border = 0;
                tablaCabecera.AddCell(dato4);
                ////////////////////////////////////////////////
                datoCabecera5.UseVariableBorders = true;
                datoCabecera5.Border = 0;
                tablaCabecera.AddCell(datoCabecera5);
                ////////////////////////////////////////////////
                dato5.UseVariableBorders = true;
                dato5.Border = 0;
                tablaCabecera.AddCell(dato5);
                ////////////////////////////////////////////////
                datoCabecera6.UseVariableBorders = true;
                datoCabecera6.Border = 0;
                tablaCabecera.AddCell(datoCabecera6);
                ////////////////////////////////////////////////
                dato6.UseVariableBorders = true;
                dato6.Border = 0;
                tablaCabecera.AddCell(dato6);
                ////////////////////////////////////////////////
                datoCabecera7.UseVariableBorders = true;
                datoCabecera7.Border = 0;
                tablaCabecera.AddCell(datoCabecera7);
                ////////////////////////////////////////////////
                dato7.UseVariableBorders = true;
                dato7.Border = 0;
                tablaCabecera.AddCell(dato7);
                ////////////////////////////////////////////////
                pdfDocument.Add(tablaCabecera);

                Paragraph p = new Paragraph();
                PdfPTable tablaTitulo = new PdfPTable(4);
                PdfPCell datoTablatitulo = new PdfPCell(new Phrase("DECLARACION DE EXISTENCIA ANIMAL"));
                tablaTitulo.AddCell(datoTablatitulo);
                p.Add(tablaTitulo);

                PdfPTable table = new PdfPTable(4);
                //PdfPCell cell = new PdfPCell(new Phrase("DECLARACION DE EXISTENCIA ANIMAL"));
                PdfPCell cCabecera1 = new PdfPCell(new Phrase("Especie"));
                PdfPCell cCabecera2 = new PdfPCell(new Phrase("Clase"));
                PdfPCell cCabecera3 = new PdfPCell(new Phrase("Categoria"));
                PdfPCell cCabecera4 = new PdfPCell(new Phrase("Cantidad"));

                table.AddCell(cCabecera1);
                table.AddCell(cCabecera2);
                table.AddCell(cCabecera3);
                table.AddCell(cCabecera4);
                table.AddCell("dato");
                table.AddCell("dato");
                table.AddCell("dato");
                table.AddCell("dato");

                p.Add(table);

                pdfDocument.Add(p);
                pdfDocument.Close();

            }
            catch (Exception ex)
            {

            }

        }


    }
}