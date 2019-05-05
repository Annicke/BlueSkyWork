Feature: wishlist
	As a user of Gifrete
	I want to create a Whislist
	So that I can purchase items

@Background
Scenario: Background Scenario
	Given I navigate to the site
	When I click on login
	And I input my email address
	And I input my password
	And I click on login button
	Then  my user profile is displayed


Scenario: Wishlist
	Given I click on my profile
	And I click on wishlist from the drop down menu
	And I click on create 
	When I select radio text
	And I enter occasion
	And I select even date
	And I enter wishlist description
	And I select category
	And I choose wishlist image
	And I click on save wishlist
	Then the wishlist is created