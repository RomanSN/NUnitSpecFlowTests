﻿Feature: LoginFeature
	In order to test login functionality
	As a admin user
	I want to be able to log in to the app

@ignore
Scenario Outline: Log in to the Gtpl bank app
	Given When user navigate to Gtpl Bank login page
	And type <userId> as userId into UserId field
	And type <password> as password into Password field
	When the Login button is clicked
	Then main page of the application is opened
Examples: 
| userId | password |
| x      | y        |
