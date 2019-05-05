Feature: Login
	
	As a User of Giftrete 
	I want to Login
	So that I can use the site

@mytag
Scenario: Login
	Given I navigate to the site
	When I click on login
	And I input my email address
	And I input my password
	And I click on login button
	Then  my user profile is displayed
