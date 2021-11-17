using AutomacaoTest.AcessandoSistema.Page;
using AutomacaoTest.core;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;


using static AutomacaoTest.core.DriverFactory;

namespace AutomacaoTest.AcessandoSistema.Teste
{
    public class TelaAcessoTest:BaseTest
    {
        private TelaAcessoPage page;

        [SetUp]
        public void IniciarFerramenta()
        {
            page = new TelaAcessoPage();
        }



        [Test]

        public void Test1()
        {
            page.acessarSistema();   
            page.clicaBotao();
            Thread.Sleep(5000);
        }
    }
}
