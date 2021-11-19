
using AutomacaoTest.core.util;
using OpenQA.Selenium;
using System;
using static AutomacaoTest.core.DriverFactory;


namespace AutomacaoTest.core
{
    public class BasePage: ScreenshotPDF
    {
        private ScreenshotImages capturaImagens;
        private static String URL_SISTEMA = "http://automationpractice.com/index.php";
        
        public void acessarSistema()
        {
            try {
                getDriver().Navigate().GoToUrl(URL_SISTEMA);
            }
            catch(Exception e) {
                this.capturaImagens.capturaTelaErro();
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
                this.capturaImagens.capturaTelaErro();
                throw;
            }

                                   
        }
    }
}
