using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using static AutomacaoTest.core.DriverFactory;


namespace AutomacaoTest.core
{
   public class BaseTest
    {
  

        [SetUp]
        public void Setup()
        {
            getDriver().Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        [TearDown]
        public void Finish()
        {   
            getDriver().Close();
        }

        [TearDown]
        public void finalizarTeste() {
            try { 
                Finish();
            }
            catch {
                Screenshot imagem = ((ITakesScreenshot)getDriver()).GetScreenshot();
                string title = ScenarioContext.Current.ScenarioInfo.Title;
                string Runname = title + DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss");
                string screenshotfilename = "C:\\screenshots\\" + Runname + ".jpg";
                imagem.SaveAsFile(screenshotfilename, ScreenshotImageFormat.Png); 
            }
            
        }

    }
}

/*
  Screenshot ss = ((ITakesScreenshot)Browser).GetScreenshot();
 string title = ScenarioContext.Current.ScenarioInfo.Title;
 string Runname = title + DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss");
 string screenshotfilename = "X:\\screenshots\\" + Runname + ".jpg";
 ss.SaveAsFile(screenshotfilename, System.Drawing.Imaging.ImageFormat.Jpeg);
 */
