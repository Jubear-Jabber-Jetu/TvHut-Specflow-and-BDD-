Feature: Web Page Verification
 Scenario: Verify that account button works fine
    Given Go to Tv Hut page
    Then  Check account button is available

 Scenario: Verify that page title is not null and as expected
    Given Go to Tv Hut page
    Then Check title is not null and as expected

  Scenario: Verify that search bar is available
    Given Go to Tv Hut page
    Then Check search bar is available