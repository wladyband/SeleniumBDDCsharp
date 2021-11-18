using AutomacaoTest.core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoTest.AcessandoSistema.Page
{
    public class TelaAcessoPage: BasePage
    {
        public void clicaBotao() {
            clicarButton(By.XPath("//a[@class='loginw']"));
        }

    }
}
