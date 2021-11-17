using OpenQA.Selenium;
using System;
using System.IO;
using static AutomacaoTest.core.DriverFactory;

namespace AutomacaoTest.core
{
    public class BasePage
    {
        private static String URL_SISTEMA = "http://automationpractice.com/index.php";
        private static String CAMINHO_IMAGEM = "C://temp//Image.png";

        public void capturaTela() {
            Screenshot ss = ((ITakesScreenshot)getDriver()).GetScreenshot();
            ss.SaveAsFile(CAMINHO_IMAGEM, ScreenshotImageFormat.Png);

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
