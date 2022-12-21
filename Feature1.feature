Feature: Login

A short summary of the feature


@tag1
Scenario: Perform Login page
	Given lanuch the application
	And I enter following details
		| username      | password     |
		| standard_user | secret_sauce |
	And I click on login button
	Then It should navigate to home page


@tag2
Scenario: Add to cart
	Given Iam in home page
	When I click on add to cart button
	And I click on  cart icon
	Then It should navigate to cart page




@tag3
Scenario: Perform About page
	Given navigate to home page
	And click on menubar
	And click on about
	Then It should navigate to about page





	



