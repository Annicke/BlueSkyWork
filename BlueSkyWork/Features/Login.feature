﻿Feature: Login
	In order to use Giftrete site
	As a user
	I want to login

@ValidLogin
@mytag
Scenario: Login
	Given I navigate to the site
	When I click on login
	And I input my email address
	And I input my password
	And I click on login button
	Then  my user profile is displayed


