using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoTest.core
{
	public class DriverFactory
	{
		private static WebDriver driver;

		private DriverFactory()
		{
		}

		public static WebDriver getDriver()
		{
			if (driver == null)
			{
				switch (Propriedades.browser)
				{
					case Navegador.FIREFOX:

						driver = new FirefoxDriver();
						break;
					case Navegador.CHROME:
						driver = new ChromeDriver();
						break;
					case Navegador.IE:
						driver = new InternetExplorerDriver();
						break;
				}
				driver.Manage().Window.Maximize();
			}
			return driver;
		}

		public static void killDriver()
		{
			if (driver != null)
			{
				driver.Close();
				driver = null;
			}

		}
	}
}
