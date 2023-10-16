Feature: Sorting Products
  As a user,
  I want to be able to sort products on the website,
  So that I can easily find the products I'm looking for.

  Scenario: User sorts products by price
    Given the user is on the product listing page
    When the user selects Price from the sort options
    Then the products are displayed in ascending order of price
