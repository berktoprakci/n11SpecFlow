using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecFlowDemo.PageObjects;

namespace SpecFlowDemo.PageObjects
{
    public class WishlistPageObjects
    {

        private static IWebDriver _driver;

        public WishlistPageObjects(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }


        [FindsBy(How = How.CssSelector, Using = "ul .listItemProductList li a")]
        public IWebElement favoritesBtn { get; set; }

        public void FavoritesList()
        {
            favoritesBtn.Click();
            //driver.FindElement(By.CssSelector("ul .listItemProductList li a")).Click();
        }

    }
    
}
