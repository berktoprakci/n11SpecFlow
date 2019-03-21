using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowParallel.PageObjects
{
    public class HeaderObjects
    {

        private static IWebDriver _driver;
        readonly BrowserStackDriver _bsDriver;

        public HeaderObjects(IWebDriver driver)
        {
            _bsDriver = (BrowserStackDriver)ScenarioContext.Current["bsDriver"];
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".btnSignIn")]
        public IWebElement loginBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#searchData")]
        public IWebElement searchTxt { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".menuLink.user")]
        public IWebElement userName { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".searchBtn")]
        public IWebElement searchBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".myAccountHolder")]
        public IWebElement accountDDL { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".hOpenMenuContent a")]
        public IList<IWebElement> accountDDLItems { get; set; }


        public void Login()
        {
            loginBtn.Click();
        }

        public void ConfirmPage(string url, string title)
        {
            Assert.AreEqual(_driver.Url, url);
            Assert.AreEqual(_driver.Title, title);
        }

        public void ConfirmUser(string fullname)
        {
            string username = userName.Text;
            Assert.AreEqual(username, fullname);
        }

        public void Search(string productname)
        {
            searchTxt.Click();
            searchTxt.SendKeys(productname);
        }

        public void SubmitSearch()
        {
            searchBtn.Click();
        }

        public void Wishlist()
        {
            Actions action = new Actions(_driver);
            action.MoveToElement(accountDDL).Perform();
            //Actions action = new Actions(driver);
            //IWebElement we = accountDDL;
            //action.MoveToElement(we).Perform();
            accountDDLItems[1].Click();
            //var a = accountDDLItems;
            //a[1].Click();
        }

        public void Navigate(string siteaddress)
        {
            _driver.Navigate().GoToUrl(siteaddress);
        }

    }
}
