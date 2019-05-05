Feature: Community
	As a User of Giftrete 
	I want to click on community 
	so that I can create the community

@Background
Scenario: Background Scenario
	Given I navigate to the site
	When I click on login
	And I input my email address
	And I input my password
	And I click on login button
	Then  my user profile is displayed

Scenario: Create Community
	Given my account is displayed
	When I click on community link
	And I click on create new
	And I enter community name
	And I enter community description
	And I select type
	And I enter my location
	And I select the privacy status 
	And I choose the file for community image
	And I click on create community 
	Then I must view my community created
