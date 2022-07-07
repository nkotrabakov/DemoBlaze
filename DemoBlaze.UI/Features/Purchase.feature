@web
Feature: Purchase

Scenario: Purchase a product successfully
	Given I navigate to main page
	And I click on Log in button
	When I input username '<username>' and password '<password>' in login form
	And I click on Log in button on pop up
	And I click on a product
	And I add it to cart
	And I click on Cart button
	And I click on Place Order button
	And I enter the following data:
	| name | country  | city  | creditcard          | month | year |
	| John | Bulgaria | Sofia | 1111 2222 3333 4444 | 04    | 2022 |
	And I click on Purchase button
	Then I see information for the placed order

	Examples:
	|username	|password|
	|johnnewton |john123 |
