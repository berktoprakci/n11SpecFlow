using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using BrowserStack;


namespace ParallelBrowserStack.PageObjects
{
    public class BasePage
    {

        private static IWebDriver _driver;
        readonly BrowserStackDriver _bsDriver;

        public BasePage(IWebDriver driver)
        {
            _bsDriver = (BrowserStackDriver)ScenarioContext.Current["bsDriver"];
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }


        public void InitTest(string profile, string environment)
        {
            //_driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //_driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
        }

    }
}
