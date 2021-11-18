using OpenQA.Selenium;
using System;
using System.Globalization;
using System.IO;
using static AutomacaoTest.core.DriverFactory;

namespace AutomacaoTest.core
{
    public class BasePage
    {       
        private static String URL_SISTEMA = "http://automationpractice.com/index.php";
        private static String CAMINHO_IMAGEM = @"evidencias\..\..\..\evidendias";

        public void capturaTela()
        {
            var fullpath = Path.GetFullPath(CAMINHO_IMAGEM); 
            Screenshot imagem = ((ITakesScreenshot)getDriver()).GetScreenshot();
            string dataHora = DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss", CultureInfo.GetCultureInfo("pt-BR"));
            String telaCapturada = fullpath + "telaCapturada" + "_" + dataHora + ".png"; 
            imagem.SaveAsFile(telaCapturada, ScreenshotImageFormat.Png);

        }

        public void acessarSistema()
        {
            try {
                getDriver().Navigate().GoToUrl(URL_SISTEMA);
            }
            catch(Exception e) {
                this.capturaTela();
                throw;
            }
            
        }

        public void clicarButton(By by)
        {
            try
            {
                IWebElement element = getDriver().FindElement(by);
                element.Click();

            }
            catch (Exception e)
            {
                this.capturaTela();
                throw;
            }

                                   
        }
    }
}
