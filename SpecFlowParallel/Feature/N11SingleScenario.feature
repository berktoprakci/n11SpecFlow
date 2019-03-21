Feature: N11SingleScenario
	This feature will test functionality of loging in, searching a product from product seaching page after than adding and deleting that product to the User basket from HomePage

@mytag
Scenario Outline: 1.Navigate to site's HomePage 2.Successful login with Valid Credential 3.Product searching with query 4.Navigate through search result page by pagination 5.Adding product from above to favorites 6.Deleting the product from favorites list
	* User <profile> at <environment> browser home page
	* User navigate to <siteaddress>
	* Page title and landed url should <pagetitle> and <siteurl>
	* User at  Homepage
	* User Navigating to LogIn Page
	* User enter <username> and <password>
	* Click on the LogIn button
	* User <fullname> should be visible under my account section
	* User at Homepage after Successful login
	* User Typing <productname> to searchbar
	* Clicking to the search button in order to search for that product
	* User should see the search results with <productname>
	* User is on the first page of searching results
	* User is selecting <pagenumber> from pagination
	* User should see the <pagenumber> th search page results
	* User is on the nth page of searching results
	* User adding the <queuenumber> th product from above to favorites list
	* User navigating to their favorites list
	* User should see the added product in their list
	* User is at their favorites list
	* User deletes a product in that list
	* User should not see the deleted product in list
	Examples: 
	| siteaddress           | pagetitle                             | siteurl                | profile    | environment | username                 | password      | fullname        | productname | pagenumber | queuenumber |
	| 'http://www.n11.com/' | 'n11.com - Alışverişin Uğurlu Adresi' | 'https://www.n11.com/' | 'parallel' | 'chrome'    | 'berktoprakci@gmail.com' | 'Test1ngpass' | 'Berk Toprakçı' | 'samsung'   | '2'        | '3'         |
	| 'http://www.n11.com/' | 'n11.com - Alışverişin Uğurlu Adresi' | 'https://www.n11.com/' | 'parallel' | 'firefox'   | 'berktoprakci@gmail.com' | 'Test1ngpass' | 'Berk Toprakçı' | 'samsung'   | '2'        | '3'         |
	| 'http://www.n11.com/' | 'n11.com - Alışverişin Uğurlu Adresi' | 'https://www.n11.com/' | 'parallel' | 'ie'        | 'berktoprakci@gmail.com' | 'Test1ngpass' | 'Berk Toprakçı' | 'samsung'   | '2'        | '3'         |
	| 'http://www.n11.com/' | 'n11.com - Alışverişin Uğurlu Adresi' | 'https://www.n11.com/' | 'parallel' | 'safari'    | 'berktoprakci@gmail.com' | 'Test1ngpass' | 'Berk Toprakçı' | 'samsung'   | '2'        | '3'         |