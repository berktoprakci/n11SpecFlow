Feature: N11CartWishlistFunctions
	This feature will test functionality of loging in, searching a product from product seaching page after than adding and deleting that product to the User basket from HomePage

@mytag
Scenario Outline: 1Navigate to site's HomePage
	Given User <profile> at <environment> browser home page
	When User navigate to <siteaddress>
	Then Page title and landed url should <pagetitle> and <siteurl>
	Examples: 
	| siteaddress           | pagetitle                             | siteurl                | profile  | environment |
	| 'http://www.n11.com/' | 'n11.com - Alışverişin Uğurlu Adresi' | 'https://www.n11.com/' | 'single' | 'chrome'    |

	Scenario Outline: 2Successful login with Valid Credential
	Given User at  Homepage
	And User Navigating to LogIn Page
	When User enter <username> and <password>
	And Click on the LogIn button
	Then User <fullname> should be visible under my account section
	Examples:
	| username                 | password      | fullname        |
	| 'berktoprakci@gmail.com' | 'Test1ngpass' | 'Berk Toprakçı' |

	Scenario Outline: 3Product searching with query
	Given User at Homepage after Successful login
	And User Typing <productname> to searchbar
	When Clicking to the search button in order to search for that product
	Then User should see the search results with <productname>
	Examples: 
	| productname |
	| 'samsung'   |

	Scenario Outline: 4Navigate through search result page by pagination
	Given User is on the first page of searching results
	And User is selecting <pagenumber> from pagination
	Then User should see the <pagenumber> th search page results
	Examples: 
	| pagenumber |
	| '2'        |          
	 

	Scenario Outline: 5Adding product from above to favorites
	Given User is on the nth page of searching results
	And User adding the <queuenumber> th product from above to favorites list
	When User navigating to their favorites list
	Then User should see the added product in their list
	Examples: 
	| queuenumber |
	| '3'         |      
	

	Scenario:  6Deleting the product from favorites list
	Given User is at their favorites list
	When User deletes a product in that list
	Then User should not see the deleted product in list
