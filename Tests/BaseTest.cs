using TesteRafaellaDoria.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Drawing;

namespace TesteRafaellaDoria.Tests
{
    public class BaseTest
    {
        public IWebDriver driver;
        public HomePage homePage;
        
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();

            driver.Manage().Window.Size = new Size(1440, 900);
            driver.Navigate().GoToUrl("https://www.unimed.coop.br/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            homePage = new HomePage(driver);
        }
        [TearDown]
        public void Finish()
        {
            driver.Close();
        }


    }
}
