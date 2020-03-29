using iTextSharp.text;
using Image = iTextSharp.text.Image;
using Rectangle = iTextSharp.text.Rectangle;

namespace ExportAsPDF.PDFHelpers
{
    public class ImageHelper
    {
        public Image ReziseImg(string path)
        {
            Image img = Image.GetInstance(path);
            //img.ScaleAbsolute(159f, 159f); //-->absoluto(llena todo el espacio disponible)
            //img.ScalePercent(5f);
            //Rectangle rec = new Rectangle(80f, 80f, 80f, 50f);
            img.ScaleAbsolute(100, 100);
            img.Border = Rectangle.NO_BORDER;

            img.BorderColor = BaseColor.WHITE;

            img.BorderWidth = 5f;
            //PdfPTable table = new PdfPTable(1);
            //table.AddCell(img);
            return img;
        }

        //public string ReziseImg(string path)
        //{
        //    //var source = Image.FromFile(path);
        //    //var target = new Bitmap(250, 250);
        //    //var g = Graphics.FromImage(target);

        //    //return g;

        //    //Image img = Image.GetInstance(path);
        //    ////img.ScaleAbsolute(159f, 159f); //-->absoluto(llena todo el espacio disponible)
        //    ////img.ScalePercent(5f);
        //    //img.ScaleToFit(250f, 250f);
        //    //PdfPTable table = new PdfPTable(1);
        //    //table.AddCell(img);
        //    //return table;
        //    Image original = Image.FromFile(@"C:\path\to\some.jpg");
        //    Image resized = ResizeImage(original, new Size(1024, 768));
        //    MemoryStream memStream = new MemoryStream();
        //    resized.Save(memStream, ImageFormat.Jpeg);
        //}




        //public static Image ResizeImage(Image image, Size size,
        //    bool preserveAspectRatio = true)
        //{
        //    int newWidth;
        //    int newHeight;
        //    if (preserveAspectRatio)
        //    {
        //        int originalWidth = image.Width;
        //        int originalHeight = image.Height;
        //        float percentWidth = (float)size.Width / (float)originalWidth;
        //        float percentHeight = (float)size.Height / (float)originalHeight;
        //        float percent = percentHeight < percentWidth ? percentHeight : percentWidth;
        //        newWidth = (int)(originalWidth * percent);
        //        newHeight = (int)(originalHeight * percent);
        //    }
        //    else
        //    {
        //        newWidth = size.Width;
        //        newHeight = size.Height;
        //    }
        //    Image newImage = new Bitmap(newWidth, newHeight);
        //    using (Graphics graphicsHandle = Graphics.FromImage(newImage))
        //    {
        //        graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic;
        //        graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight);
        //    }
        //    return newImage;
        //}


    }
}
