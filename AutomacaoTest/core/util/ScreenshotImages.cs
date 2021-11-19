using OpenQA.Selenium;
using System;
using System.Globalization;
using System.IO;
using static AutomacaoTest.core.DriverFactory;

namespace AutomacaoTest.core.util
{
    public class ScreenshotImages
    {

        private static String CAMINHO_IMAGEM = @"evidencias\..\..\";

        public void capturaTelaErro()
        {
            var fullpath = Path.GetFullPath(CAMINHO_IMAGEM);

            Screenshot imagem = ((ITakesScreenshot)getDriver()).GetScreenshot();
            string dataHora = DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss", CultureInfo.GetCultureInfo("pt-BR"));
            String telaCapturada = fullpath + "telaCapturada" + "_" + dataHora + ".png";
            String telaCapturadaPDF = dataHora + ".pdf";
            imagem.SaveAsFile(telaCapturada, ScreenshotImageFormat.Png);
            
        }
    }
}
