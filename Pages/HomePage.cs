using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TesteRafaellaDoria.Pages
{
    public class HomePage
    {
        private readonly IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void PesquisarGeralRioDeJaneiro()
        {
            _driver.FindElement(By.XPath("//ul[2]/li/a")).Click();
            TimeSpan.FromSeconds(5);
            _driver.FindElement(By.Id("react-tabs-2")).Click();
            TimeSpan.FromSeconds(5);
            _driver.FindElement(By.Id("province-input")).Click();
            TimeSpan.FromSeconds(5);
            _driver.FindElement(By.XPath("//div[19]/span")).Click();
            TimeSpan.FromSeconds(5);
            _driver.FindElement(By.XPath("//div[6]/div/button")).Click();
        }

        public IWebElement ValidarPaginaDeBuscasGuiaMedico()
        {
           return _driver.FindElement(By.XPath("//div[@id='gm-v3-root']/div/div[2]/div/span"));
        }

        public void PesquisarMedicosRioDeJaneiro()
        {
            _driver.FindElement(By.XPath("//div[7]/div/div/div/div/div")).Click();
            TimeSpan.FromSeconds(5);
            _driver.FindElement(By.Id("react-select-12-option-0")).Click();
            TimeSpan.FromSeconds(5);
            _driver.FindElement(By.XPath("//div[@id='gm-v3-root']/div/div[2]/div/form/button")).Click();
            
        }
    }
}
