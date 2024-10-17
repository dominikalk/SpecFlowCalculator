Feature: Calculator

Scenario: Add two numbers
	Given the first number is <first>
	And the second number is <second>
	When the two numbers are added
	Then the result should be <result>

	Examples: 
		| first | second | result |
		| 0     | 0      | 0      |
		| 4     | 4      | 8      |
		| 0     | 10     | 10     |

Scenario: Subtract two numbers
    Given the first number is <first>
    And the second number is <second>
    When the two numbers are subtracted
    Then the result should be <result>

	Examples: 
		| first | second | result |
		| 0     | 0      | 0      |
		| 8     | 4      | 4      |
		| 0     | 10     | -10    |

Scenario: Multiply multiple numbers
    When the numbers <numbers> are multiplied
    Then the result should be <result>

	Examples: 
		| numbers | result |
		| 1,2,3,4 | 24     |
		| 5       | 5      |
		| 0, 4    | 0      |
		| 10, -4  | -40    |