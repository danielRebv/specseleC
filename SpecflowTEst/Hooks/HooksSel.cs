
using Allure.Commons;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SpecflowTEst.Hooks
{
    
    
    [Binding]
    public class HooksSel

    {
        


        private readonly IObjectContainer _objectContainer;
        private IWebDriver _driver;
        public static AllureLifecycle allure = AllureLifecycle.Instance;
      


        public HooksSel(IObjectContainer objectContainer) => _objectContainer = objectContainer;

        [BeforeTestRun]
        public static void BeforeTestRuns()
        {
            allure.CleanupResultDirectory(); 
        }
        
        [BeforeScenario]
        public void initialize()
        {
            _driver = new ChromeDriver();
            _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
            _driver.Manage().Window.Maximize();
        }

     

        [AfterScenario]
        public void CleanUp()
        {
           _driver.Quit();  
        }
    }
}