Feature: WikipediaSearch
	Feature to test Wikipedia search functionality 
	Here we will test auto-search and validating
    as well as navigating to search result

@mytag
Scenario: Wikipedia Search
	Given I have navigated to Wikipedia page
	And I wikipedia page fully loaded
	When I type search keyword as
	|Keyword          |
	| Test Automation |
	Then the result should be for keyword
	|Keyword          |
	| Test Automation |
