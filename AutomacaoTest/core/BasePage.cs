using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutomacaoTest.core.DriverFactory;

namespace AutomacaoTest.core
{
    public class BasePage
    {
        public void clicarButton(By by)
        {
            IWebElement element = getDriver().FindElement(by);
            element.Click();
        }
    }
}
