using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using ParallelBrowserStack.PageObjects;


namespace ParallelBrowserStack.Step
{
    [Binding]
    public class N11SingleScenarioSteps
    {
        private static IWebDriver _driver;
        readonly BrowserStackDriver _bsDriver;

        public N11SingleScenarioSteps()
        {
            _bsDriver = (BrowserStackDriver)ScenarioContext.Current["bsDriver"];
        }


        private static string productSerialNumber;

        [Given(@"User '(.*)' at '(.*)' browser home page")]
        public void GivenUserAtBrowserHomePage(string profile, string environment)
        {
            _driver = _bsDriver.Init(profile, environment);
            BasePage page = new BasePage(_driver);
            page.InitTest(profile, environment);
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
            
        }

        [Given(@"User is at their favorites list")]
        public void GivenUserİsAtTheirFavoritesList()
        {

        }

        [Given(@"User navigate to '(.*)'")]
        public void WhenUserNavigateTo(string sitedaddress)
        {
            HeaderObjects page = new HeaderObjects(_driver);
            page.Navigate(sitedaddress);
            
        }

        [Given(@"User enter '(.*)' and '(.*)'")]
        public void WhenUserEnterAnd(string username, string password)
        {
            LoginPageObjects page = new LoginPageObjects(_driver);
            page.Fill(username, password);
            
        }

        [Given(@"Click on the LogIn button")]
        public void WhenClickOnTheLogInButton()
        {
            LoginPageObjects page = new LoginPageObjects(_driver);
            page.loginBtn.Click();
            
        }

        [Given(@"Clicking to the search button in order to search for that product")]
        public void WhenClickingToTheSearchButtonİnOrderToSearchForThatProduct()
        {
            HeaderObjects page = new HeaderObjects(_driver);
            page.SubmitSearch();
           
        }

        [Given(@"User navigating to their favorites list")]
        public void WhenUserNavigatingToTheirFavoritesList()
        {
            HeaderObjects page = new HeaderObjects(_driver);
            page.Wishlist();
            WishlistPageObjects whPage = new WishlistPageObjects(_driver);
            whPage.FavoritesList();

            
        }

        [Given(@"User deletes a product in that list")]
        public void WhenUserDeletesAProductİnThatList()
        {
            FavoritesPageObjects page = new FavoritesPageObjects(_driver);
            page.DeleteProduct();
            
        }

        [Given(@"Page title and landed url should '(.*)' and '(.*)'")]
        public void ThenPageTitleAndLandedUrlShouldAnd(string pagetitle, string siteurl)
        {
            HeaderObjects page = new HeaderObjects(_driver);
            page.ConfirmPage(siteurl, pagetitle);
            
        }

        [Given(@"User '(.*)' should be visible under my account section")]
        public void ThenUserShouldBeVisibleUnderMyAccountSection(string fullname)
        {
            HeaderObjects page = new HeaderObjects(_driver);
            page.ConfirmUser(fullname);
            
        }

        [Given(@"User should see the search results with '(.*)'")]
        public void ThenUserShouldSeeTheSearchResultsWith(string productname)
        {
            SearchPageObjects page = new SearchPageObjects(_driver);
            page.ConfirmSearchResults(productname);
            
        }

        [Given(@"User should see the '(.*)' th search page results")]
        public void ThenUserShouldSeeTheThSearchPageResults(string pagenumber)
        {
            SearchPageObjects page = new SearchPageObjects(_driver);
            page.ConfirmPageNumber(pagenumber);
            
        }


        [Given(@"User should see the added product in their list")]
        public void ThenUserShouldSeeTheAddedProductİnTheirList()
        {
            FavoritesPageObjects page = new FavoritesPageObjects(_driver);
            page.FindProduct(productSerialNumber);
            
        }

        [Given(@"User should not see the deleted product in list")]
        public void ThenUserShouldNotSeeTheDeletedProductİnList()
        {
            FavoritesPageObjects page = new FavoritesPageObjects(_driver);
            page.confirmThatProductIsDeleted(productSerialNumber);
            _driver.Quit();

        }
    }
}
