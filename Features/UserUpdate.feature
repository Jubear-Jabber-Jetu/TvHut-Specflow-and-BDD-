Feature: User Updates Personal Details

  Scenario: Verify that an user can change or update user's information
    Given Log in
    And Click update information option
    When  Enter First name
    And Enter Last name
    And Enter email
    And Enter phone number
    And Click on submit
    Then Check that profile is updated
