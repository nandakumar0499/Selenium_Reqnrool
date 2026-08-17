Feature: Search_product

A short summary of the feature

@tag1
Scenario: verify CartFuncationality
	Given Navigate to the Broswer
	When open The  URL
	Then search for Loptop
    Then Get all search result
    Then print product name and price
	Then add first product to cart 
    When verify the product is added to cart
   

