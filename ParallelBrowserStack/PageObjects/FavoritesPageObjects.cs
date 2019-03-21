using NUnit.Framework;
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
    public class FavoritesPageObjects
    {

        private static IWebDriver _driver;
        readonly BrowserStackDriver _bsDriver;

        public FavoritesPageObjects(IWebDriver driver)
        {
            _bsDriver = (BrowserStackDriver)ScenarioContext.Current["bsDriver"];
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "div.wishProBtns span.deleteProFromFavorites")]
        public IWebElement deleteBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".btn.btnBlack.confirm")]
        public IWebElement confirmBtn { get; set; }

        public void FindProduct(string productserialnumber)
        {
            _driver.FindElement(By.Id(productserialnumber));
        }

        public void DeleteProduct()
        {
            deleteBtn.Click();
            confirmBtn.Click();
        }

        public void confirmThatProductIsDeleted(string productserialnumber)
        {
            bool we = false;
            if (_driver.FindElements(By.Id(productserialnumber)).Count != 0)
            {
                we = true;
            }
            Assert.That(we, Is.True);
        }
    }
}
