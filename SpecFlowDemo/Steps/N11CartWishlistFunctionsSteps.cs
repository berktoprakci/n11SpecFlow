using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SpecFlowDemo.PageObjects;

namespace SpecFlowDemo.Steps
{
    [Binding]
    public class N11CartWishlistFunctionsSteps
    {

        private static IWebDriver _driver = new ChromeDriver();
            

        //public N11CartWishlistFunctionsSteps()
        //{
        //}


        //public static IWebDriver driver;
        private string productSerialNumber;

        [Given(@"User at browser's home page")]
        public void GivenUserAtBrowserSHomePage()
        {
            BasePage page = new BasePage(_driver);
            page.InitTest();
            //driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        
        [Given(@"User at  Homepage")]
        public void GivenUserAtHomepage()
        {
             
        }
        
        [Given(@"User Navigating to LogIn Page")]
        public void GivenUserNavigatingToLogInPage()
        {
            HeaderObjects page = new HeaderObjects(_driver);
            page.Login();
            //driver.FindElement(By.CssSelector(".btnSignIn")).Click();
        }
        
        [Given(@"User at Homepage after Successful login")]
        public void GivenUserAtHomepageAfterSuccessfulLogin()
        {
            
        }
        
        [Given(@"User Typing '(.*)' to searchbar")]
        public void GivenUserTypingToSearchbar(string productname)
        {
            HeaderObjects page = new HeaderObjects(_driver);
            page.Search(productname);
            //driver.FindElement(By.CssSelector("#searchData")).SendKeys(productname);
        }
        
        [Given(@"User is on the first page of searching results")]
        public void GivenUserİsOnTheFirstPageOfSearchingResults()
        {
            
        }

        [Given(@"User is selecting '(.*)' from pagination")]
        public void GivenUserİsSelectingFromPagination(int pagenumber)
        {
            SearchPageObjects page = new SearchPageObjects(_driver);
            page.ChangePageNumber(pagenumber);
            //var p = driver.FindElements(By.CssSelector(".pagination a"));
            //p[pagenumber - 1].Click();
        }


        [Given(@"User is on the nth page of searching results")]
        public void GivenUserİsOnTheNthPageOfSearchingResults()
        {
            
        }

        [Given(@"User adding the '(.*)' th product from above to favorites list")]
        public void GivenUserAddingTheThProductFromAboveToFavoritesList(int queuenumber)
        {
            SearchPageObjects page = new SearchPageObjects(_driver);
            productSerialNumber = page.AddToFavorites(queuenumber);
            //var p = driver.FindElements(By.CssSelector("section.resultListGroup div ul li div.columnContent"));
            //productSerialNumber = p[queuenumber - 1].GetAttribute("id");
            //var f = driver.FindElements(By.CssSelector(".textImg.followBtn"));
            //f[queuenumber - 1].Click();
        }

        [Given(@"User is at their favorites list")]
        public void GivenUserİsAtTheirFavoritesList()
        {
            
        }
        
        [When(@"User navigate to '(.*)'")]
        public void WhenUserNavigateTo(string sitedaddress)
        {
            BasePage page = new BasePage(_driver);
            page.Navigate(sitedaddress);
            //driver.Url = sitedaddress;
        }
        
        [When(@"User enter '(.*)' and '(.*)'")]
        public void WhenUserEnterAnd(string username, string password)
        {
            LoginPageObjects page = new LoginPageObjects(_driver);
            page.Fill(username, password);
            //driver.FindElement(By.CssSelector("#email")).SendKeys(username);
            //driver.FindElement(By.CssSelector("#password")).SendKeys(password);
        }
        
        [When(@"Click on the LogIn button")]
        public void WhenClickOnTheLogInButton()
        {
            LoginPageObjects page = new LoginPageObjects(_driver);
            page.loginBtn.Click();
            //driver.FindElement(By.CssSelector("#loginButton")).Click();
        }
        
        [When(@"Clicking to the search button in order to search for that product")]
        public void WhenClickingToTheSearchButtonİnOrderToSearchForThatProduct()
        {
            HeaderObjects page = new HeaderObjects(_driver);
            page.SubmitSearch();
            //driver.FindElement(By.CssSelector(".searchBtn")).Click();
        }
        
        [When(@"User navigating to their favorites list")]
        public void WhenUserNavigatingToTheirFavoritesList()
        {
            HeaderObjects page = new HeaderObjects(_driver);
            page.Wishlist();
            WishlistPageObjects whPage = new WishlistPageObjects(_driver);
            whPage.FavoritesList();

            //Actions action = new Actions(driver);
            //IWebElement we = (driver.FindElement(By.CssSelector(".myAccountHolder")));
            //action.MoveToElement(we).Perform();
            //var a = driver.FindElements(By.CssSelector(".hOpenMenuContent a"));
            //a[1].Click();
            //driver.FindElement(By.CssSelector("ul .listItemProductList li a")).Click();
        }
        
        [When(@"User deletes a product in that list")]
        public void WhenUserDeletesAProductİnThatList()
        {
            FavoritesPageObjects page = new FavoritesPageObjects(_driver);
            page.DeleteProduct();
            //driver.FindElement(By.CssSelector("div.wishProBtns span.deleteProFromFavorites")).Click();
            //driver.FindElement(By.CssSelector(".btn.btnBlack.confirm")).Click();
        }
        
        [Then(@"Page title and landed url should '(.*)' and '(.*)'")]
        public void ThenPageTitleAndLandedUrlShouldAnd(string pagetitle, string siteurl)
        {
            HeaderObjects page = new HeaderObjects(_driver);
            page.ConfirmPage(siteurl, pagetitle);
            //Assert.AreEqual(driver.Title, pagetitle);
            //Assert.AreEqual(driver.Url, siteurl);
        }

        [Then(@"User '(.*)' should be visible under my account section")]
        public void ThenUserShouldBeVisibleUnderMyAccountSection(string fullname)
        {
            HeaderObjects page = new HeaderObjects(_driver);
            page.ConfirmUser(fullname);
            //string username = driver.FindElement(By.CssSelector(".menuLink.user")).Text;
            //Assert.AreEqual(username, fullname);
        }
        
        [Then(@"User should see the search results with '(.*)'")]
        public void ThenUserShouldSeeTheSearchResultsWith(string productname)
        {
            SearchPageObjects page = new SearchPageObjects(_driver);
            page.ConfirmSearchResults(productname);
            //var results = driver.FindElements(By.CssSelector("section div ul li div div h3.productName.bold"));
            //foreach (IWebElement we in results)
            //{
            //    string text = we.Text.ToLower();
            //    StringAssert.Contains(productname, text);
            //}
        }

        [Then(@"User should see the '(.*)' th search page results")]
        public void ThenUserShouldSeeTheThSearchPageResults(string pagenumber)
        {
            SearchPageObjects page = new SearchPageObjects(_driver);
            page.ConfirmPageNumber(pagenumber);
            //string c = driver.FindElement(By.CssSelector(".currentPage")).GetAttribute("Value");
            //Assert.AreEqual(pagenumber, c);
        }


        [Then(@"User should see the added product in their list")]
        public void ThenUserShouldSeeTheAddedProductİnTheirList()
        {
            FavoritesPageObjects page = new FavoritesPageObjects(_driver);
            page.FindProduct(productSerialNumber);
            //driver.FindElement(By.Id(productSerialNumber));
        }
        
        [Then(@"User should not see the deleted product in list")]
        public void ThenUserShouldNotSeeTheDeletedProductİnList()
        {
            FavoritesPageObjects page = new FavoritesPageObjects(_driver);
            page.confirmThatProductIsDeleted(productSerialNumber);
            //bool we = false;
            //try
            //{
            //    driver.FindElement(By.CssSelector("#" + productSerialNumber));
            //}
            //catch (OpenQA.Selenium.NoSuchElementException e)
            //{
            //    we = true;
            //}

            //Assert.That(we, Is.True);
        }
    }
}
