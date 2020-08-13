Feature: Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to calculator the result fo one factorial 

@mytag
Scenario Outline: Factorial of the one number 
	Given that a one number <number>
	When the algorimenth to realize the operation 
	Then the result is equal <result>
	Examples:  
| number | result |
|   5    |   120  |
|	8    |  40320 |
|	6    |   720  |