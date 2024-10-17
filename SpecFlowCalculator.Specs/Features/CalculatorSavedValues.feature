Feature: Calculator Saved Values

Scenario: User bulk saves values
	When the user bulk saves 1 and 2
	Then the saved values should be
		| alpha | beta |
		| 1     | 2    |

Scenario: User updates alpha
	Given the saved values are
		| alpha | beta |
		| 1     | 2    |
	When the user updates alpha to 3
	Then the saved values should be
		| alpha | beta |
		| 3     | 2    |