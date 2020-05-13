Feature: Points Calculation
	As a player
    I want the system to calculate my score
    So I know how good I am

@mytag
Scenario: No points
	Given A new bowling game
	When All my balls land in the side gutter
	Then My total score should be 0

Scenario: Beginners game
    Given A new bowling game
    When I roll 2 and 7
    And I roll 3 and 4
    And I roll 8 times 1 and 1
    Then My total score should be 32

Scenario: Another beginner game
    Given A new bowling game
    When I roll the following series: 2,7,3,4,1,1,5,1,1,1,1,1,1,1,1,1,1,1,5,1
    Then My total score should be 40

Scenario: Strikes only 
    Given A new bowling game
    When All my rolls are strikes
    Then My total score should be 300

Scenario: One spare
    Given A new bowling game
    When I roll the following series: 3,7,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1
    Then My total score should be 29

Scenario: Spares only
    Given A new bowling game
    When I roll 10 times 1 and 9
    And I roll 1
    Then My total score should be 110
