Feature: User Updates Personal Details

  Scenario: User updates personal details on the website
    Given the user is logged in
    And the user is on the account page
    When the user enters first name in the field
    And the user enters last name in the field
    And the user enters email in the field
    And the user enters phone number in the field
    And the user clicks the submit button
    Then the user should be able to update the profile page
