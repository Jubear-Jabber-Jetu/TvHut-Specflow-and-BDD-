Feature: User Login
  As a registered user
  I want to be able to log in to the website
  So that I can access my account

  Scenario: Successful Login
    Given the user is on the login page
    When the user enters valid login credentials
    And clicks the login button
    Then the user should be logged in successfully

  Scenario: Invalid Login
    Given the user is on the login page
    When the user enters invalid login credentials
    And clicks the login button
    Then an error message should be displayed
    And the user should not be logged in
