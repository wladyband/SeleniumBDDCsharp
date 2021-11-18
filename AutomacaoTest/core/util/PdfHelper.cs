using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoTest.core.util
{
    public class PdfHelper
    {
        private PdfHelper()
        {
        }


        public void SaveImageAsPdf(string imageFileName, string pdfFileName, int width = 600)
        {
            using (var document = new PdfDocument())
            {
                PdfPage page = document.AddPage();
                using (XImage img = XImage.FromFile(imageFileName))
                {
                    // Calculate new height to keep image ratio
                    var height = (int)(((double)width / (double)img.PixelWidth) * img.PixelHeight);

                    // Change PDF Page size to match image
                    page.Width = width;
                    page.Height = height;

                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    gfx.DrawImage(img, 0, 0, width, height);
                }
                document.Save(pdfFileName);
            }

        }
    }
}
