using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ParallelBrowserStack.PageObjects
{
    public class WishlistPageObjects
    {

        private static IWebDriver _driver;
        readonly BrowserStackDriver _bsDriver;

        public WishlistPageObjects(IWebDriver driver)
        {
            _bsDriver = (BrowserStackDriver)ScenarioContext.Current["bsDriver"];
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }


        [FindsBy(How = How.CssSelector, Using = "ul .listItemProductList li a")]
        public IWebElement favoritesBtn { get; set; }

        public void FavoritesList()
        {
            favoritesBtn.Click();
            
        }

    }
    
}
