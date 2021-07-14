using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TesteRafaellaDoria.Tests
{
    public class TestCases : BaseTest
    {
        [Test]
        public void Pesquisar()
        {
            homePage.PesquisarGeralRioDeJaneiro();
            homePage.PesquisarMedicosRioDeJaneiro();
            Assert.AreEqual("Refine sua busca:", homePage.ValidarPaginaDeBuscasGuiaMedico().Text);
        }



    }
}
