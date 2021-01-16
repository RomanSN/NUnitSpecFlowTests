Feature: CustomerCRUDFeature
	As an admin user
	I want to be able to add, edit, and delete new customer

@customer
Scenario Outline: Create new user with valid data
	Given When I navigate to the main page
	And open Add customer form
	And fill form with data <name> <gender> <dob> <address> <city> <state> <pin> <phone> <email>
	When I submit creating
	Then new user is successfully added
	Examples: 
	| name       | gender | dob        | address  | city  | state | pin    | phone     | email     |
	| TestFirst  | male   | 02072000 | address1 | Opole | Opole | 221345 | 888333999 | test1@gmail.com |
	| TestSecond | female | 10071999 | address2 | Opole | Opole | 657436 | 888333999 | test2@gmail.com |

@customer
Scenario Outline: Create new user with invalid data
	Given When I navigate to the main page
	And open Add customer form
	And fill form with data <name> <gender> <dob> <address> <city> <state> <pin> <phone> <email>
	When I submit creating
	Then new user is not added, allert displayed
	Examples: 
	| name    | gender | dob      | address  | city  | state | pin    | phone     | email           |
	| TestInv | male   | 22072000 | address1 | Opole | Opole | 221345 | 888333999 | test1gmail.com  |
	| TestInv | female | 10071999 | address2 | Opole | Opole | 2233   | 888333999 | test2@gmail.com |

@customer
Scenario: Delete customer
	Given When I navigate to the main page
	And open delete customer form
	And fill form with '12345' as Id 
	When I submit deleting
	Then new user is deleted