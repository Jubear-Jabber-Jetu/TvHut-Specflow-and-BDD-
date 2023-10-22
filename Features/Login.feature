Feature: User Login
  As a registered user
  I want to be able to log in to the website
  So that I can access my account

  Scenario: Verify that an user can not log in with invalid email and password
    Given Navigate to Login page
    When Enter email in the email fied
    And  Enter password in the password field
    Then Click Login button
    And Check login status

  Scenario: Verify that an user can not log in with valid email and invalid password
    Given Navigate to Login page
    When Enter email in the email fied
    And  Enter password in the password field
    Then Click Login button
    And Check login status

  Scenario: Verify that an user can not log in with invalid email and valid password
    Given Navigate to Login page
    When Enter email in the email fied
    And  Enter password in the password field
    Then Click Login button
    And Check login status

  Scenario: Verify that an user can log in with valid email and password
    Given Navigate to Login page
    When Enter email in the email fied
    And  Enter password in the password field
    Then Click Login button
    And Check login status
