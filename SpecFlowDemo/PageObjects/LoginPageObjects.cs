using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SpecFlowDemo.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowDemo.PageObjects
{
    public class LoginPageObjects
    {

        private static IWebDriver _driver;
        readonly BrowserStackDriver _bsDriver;

        public LoginPageObjects(IWebDriver driver)
        {
            _bsDriver = (BrowserStackDriver)ScenarioContext.Current["bsDriver"];
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#email")]
        public IWebElement emailTxt { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#password")]
        public IWebElement passwordTxt { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#loginButton")]
        public IWebElement loginBtn { get; set; }

        public void Fill(string username, string password)
        {
            emailTxt.SendKeys(username);
            passwordTxt.SendKeys(password);
        }

        public void Submit()
        {
            loginBtn.Click();
        }
    }
}
