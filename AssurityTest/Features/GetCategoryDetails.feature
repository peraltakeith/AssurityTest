Feature: GetCategoryDetails
	Get category details from the API

@mytag
Scenario: Successfully Get and Verify Contents for the Categories API
	Given I call the GET categories endpoint "v1/Categories/6327/Details.json?catalogue=false"
	Then I should get a response with status code 200
	And the Name in the response should be "Carbon credits"
	And CanRelist value in the response should be true
	And the Promotions element with the name "Gallery" should have a Description that contains the text "2x larger image"