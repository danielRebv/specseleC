
using NUnit.Framework;
using OpenQA.Selenium;
using SpecflowTEst.Homepage;

namespace SpecflowTEst.StepDefinitions
{
    [Binding]
    public class GSearchSteps 
    {
        //private IWebDriver _driver;
        private HomePage _homepage;

        public GSearchSteps(HomePage homepage)
        {
            _homepage = homepage;

        }

        [Given(@"I navigate to google")]
        public void GivenINavigateToGoogle()

        {
            _homepage.goToUrl("http://www.google.com");
            //_driver.Navigate().GoToUrl("http://www.google.com");
        }

        [When(@"I Search Tsoft on google")]
        public void WhenISearchTsoftOnGoogle()
        {
            //_driver.FindElement(By.Name("q")).SendKeys("Tsoft");
            //_driver.FindElement(By.Name("q")).Submit();
            _homepage.putSearchInput("Tsoft");

        }

        [Then(@"I click Tsoft WebPage")]
        public void ThenIClickTsoftWebPage()
        {
            //_driver.FindElement(By.XPath("//h3[normalize-space()='HOME - TSOFT - Make IT Real']")).Click();
            _homepage.getSearchInput();
            _homepage.getTitle();
            Assert.IsTrue(_homepage.getTitle().Contains("Hola"));
            //Assert.IsTrue(_homepage.getTitle().Contains("HOME - TSOFT - Make IT Real"));


        }

    }
}
