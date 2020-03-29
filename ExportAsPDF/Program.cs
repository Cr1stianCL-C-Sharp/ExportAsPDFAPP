using ExportAsPDF.PDFGenerator;

namespace ExportAsPDF
{
    class Program
    {
        static void Main(string[] args)
        {
            PDFTemplate pdf = new PDFTemplate();
            pdf.CreatePDF();
        }
    }
}
