Feature: AbleAndCole

As a user, I want to be able to add these products ( Brownie Tray organic Daylesford (570g) (1), Hummus chips organic, Eat Real (100g) (3),
Simply salted popcorn organic, Nom (20g) (2).

@tag1
Scenario: Assert Products
	Given I Navigate to "https://www.abelandcole.co.uk/"
	And I Click Accept cookies 
	And I Click on search space
	And I Input product "Brownie Tray organic Daylesford (570g)"
	And I Click on search button 
	And I click on add button
	And I input product in the search space "Hummus chips organic, Eat Real (100g)"
    And I click  search button
	And I click on Addhumus button
    And I click on plus button
    And I click on plushummus button
    And I input product in the search  "Simply salted popcorn organic, Nom (20g)"
	And I Click  search key
	And I click on Addpopcorn button
	And I click on pluspopcorn button
	When I Click on basket button
	Then the basket should display six items
