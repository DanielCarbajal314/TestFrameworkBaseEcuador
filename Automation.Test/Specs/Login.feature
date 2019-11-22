Feature: Login in the App

@mytag
Scenario: Wrong password
	Given Im on the login screen
	And I write "admin" as username
	And I write "password" as password
	When I press the login button
	Then the login should fail
