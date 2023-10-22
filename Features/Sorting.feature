Feature: Verify Sorting Products

  As a user
  I want to sort products on the website
  So that I can find the desired products more easily

  Scenario: Verify that an user can sort products perfectly
    Given Navigate to product listing page
    When Click on Price ( High > Low )
    Then Check that displayed options are organized from high to low price

    Then Click on Name ( A - Z )
    Then Check that displayed options are organized in ascending order

    Then Click on Rate ( Highest )
    Then Check that displayed options are  the highest rated order


 
