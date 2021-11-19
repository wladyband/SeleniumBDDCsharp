using OpenQA.Selenium;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Globalization;
using System.IO;
using static AutomacaoTest.core.DriverFactory;

namespace AutomacaoTest.core.util
{
    public class ScreenshotPDF
    {
        private static String CAMINHO_IMAGEM = @"evidencias\..\..\..\";

        public void capturaTela()
        {
            var fullpath = Path.GetFullPath(CAMINHO_IMAGEM);

            Screenshot imagem = ((ITakesScreenshot)getDriver()).GetScreenshot();
            string dataHora = DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss", CultureInfo.GetCultureInfo("pt-BR"));
            String telaCapturada = fullpath + "telaCapturada" + "_" + dataHora + ".png";
            String telaCapturadaPDF = dataHora + ".pdf";
            imagem.SaveAsFile(telaCapturada, ScreenshotImageFormat.Png);
            this.SaveImageAsPdf(telaCapturada, fullpath + telaCapturadaPDF);
        }


        public void SaveImageAsPdf(string imageFileName, string pdfFileName, int width = 600, bool deleteImage = true)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
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
            if (deleteImage) {
                File.Delete(imageFileName);
            }
        }
    }
}
