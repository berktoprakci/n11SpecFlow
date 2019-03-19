using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowDemo.PageObjects
{
    public class FavoritesPageObjects
    {

        private static IWebDriver _driver;

        public FavoritesPageObjects(IWebDriver driver)
        {
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
            try
            {
                _driver.FindElement(By.CssSelector("#" + productserialnumber));
            }
            catch (OpenQA.Selenium.NoSuchElementException e)
            {
                we = true;
            }

            Assert.That(we, Is.True);
        }
    }
}
