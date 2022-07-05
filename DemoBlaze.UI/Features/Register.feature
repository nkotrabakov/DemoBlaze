@web
Feature: Register

Scenario: Register a new user
	Given I navigate to home page
	And I click on Sign up button
	When I input username '<username>' and password '<password>' in signup form
	And I click on Sign up button on pop up
	Then a message "Sign up successful." should appear 
	
	Examples:
	|username	|password|
	|RANDOM_USER|pass123 |

Scenario: [Failing] Unsuccessful registration with already existing user
	Given I navigate to home page
	And I click on Sign up button
	When I input username '<username>' and password '<password>' in signup form
	And I click on Sign up button on pop up
	Then an error message "There is already account with the same credentials!" should appear
	
	Examples:
	|username	|password|
	|johnnewton |john123 |