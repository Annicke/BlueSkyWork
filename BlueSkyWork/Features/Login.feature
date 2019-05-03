Feature: Login
	In order to use Giftrete site
	As a user
	I want to login

@ValidLogin
Scenario: login
	Given I navigate to the site
	When I click on login
	 And I enter my emailaddress 
	 And I enter my password
	 And I click on signin 
	 Then My account profile is displayed  

 @InValidLogin
Scenario: Invalid login
	Given I navigate to the site
	When I click on login
	 And I enter my emailaddress "sihanen@gmail.com"
	 And I enter my password
	 And I click on signin 
	 Then My account profile is not displayed

#@invalidLogin
#Scenario Outline: Invalid Login
	#Given I navigate to the site
	#When I click on login
	#And I enter my emailaddress "sihanen@email"
	#And I enter my password "1234"
	#Then messages <"messages"> is displayed for the <"test">
