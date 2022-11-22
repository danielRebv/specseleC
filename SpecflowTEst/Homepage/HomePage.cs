using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowTEst.Homepage
{
    public class HomePage
    {
        private readonly IWebDriver _driver;


        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }


        //locators

        private readonly By imputGoogle = By.Name("q");
        private readonly By tsoftGoogle = By.XPath("//h3[normalize-space()='HOME - TSOFT - Make IT Real']");


        //methods
        public HomePage putSearchInput(string _search)
        {
            _driver.FindElement(imputGoogle).SendKeys(_search);
            _driver.FindElement(imputGoogle).Submit();  
            return this;
        }

        public HomePage getSearchInput() {
            _driver.FindElement(tsoftGoogle).Click();
            return this;    
        }

        public HomePage goToUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);    
            return this;
        }

        public string getTitle()
        {
            return _driver.Title;
        }
    }
}
