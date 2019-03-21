using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowParallel.PageObjects
{
    public class SearchPageObjects
    {

        private static IWebDriver  _driver;
        readonly BrowserStackDriver _bsDriver;

        public SearchPageObjects(IWebDriver driver)
        {
            _bsDriver = (BrowserStackDriver)ScenarioContext.Current["bsDriver"];
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "section div ul li div div h3.productName.bold")]
        public IList<IWebElement> searchResults { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".pagination a")]
        public IList<IWebElement> pagination { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#currentPage")]
        public IWebElement pageNumber { get; set; }

        [FindsBy(How = How.CssSelector, Using = "section.resultListGroup div ul li div.columnContent")]
        public IList<IWebElement> productList { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".textImg.followBtn")]
        public IList<IWebElement> addFavoriteBtns { get; set; }

        public void ConfirmSearchResults(string productname)
        {
            var results = searchResults;
            foreach (IWebElement we in results)
            {
                string text = we.Text.ToLower();
                StringAssert.Contains(productname, text);
            }
        }

        public void ChangePageNumber(int pagenumber)
        {
            pagination[pagenumber - 1].Click();
            //var p = pagination;
            //p[pagenumber - 1].Click();
        }

        public void ConfirmPageNumber(string pagenumber)
        {
            string c = pageNumber.GetAttribute("Value");
            Assert.AreEqual(pagenumber, c);
        }

        public string AddToFavorites(int queuenumber)
        {
            string productserialnumber = productList[queuenumber - 1].GetAttribute("id");
            //var p = productList;
            //string productserialnumber = p[queuenumber - 1].GetAttribute("id");
            addFavoriteBtns[queuenumber - 1].Click();
            //var f = addFavoriteBtns;
            //f[queuenumber - 1].Click();

            return productserialnumber;
        }
    }

}
