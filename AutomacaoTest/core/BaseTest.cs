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
           
        }

        [TearDown]
        public void Finish()
        {
               
                getDriver().Close();
           
        }



    }
}


