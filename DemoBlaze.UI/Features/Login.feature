@web
Feature: Login

Scenario: Log in a user
	Given I navigate to main page
	And I click on Log in button
	When I input username '<username>' and password '<password>' in login form
	And I click on Log in button on pop up
	Then the user should be logged in successfully

	Examples:
	|username	|password|
	|johnnewton |john123 |