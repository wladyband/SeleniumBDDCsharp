using AutomacaoTest.AcessandoSistema.Page;
using AutomacaoTest.core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
            page.clicaBotao();
            Thread.Sleep(5000);
        }
    }
}
