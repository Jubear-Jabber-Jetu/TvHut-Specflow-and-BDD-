Feature: Category Link Verification

  Scenario: Verify that user can click all the avaliable category through the navigation bar
    Given Navigate to Tv Hut official page
    When  Click on Television
    Then Check that Television is avaliable

    When Click on the Air Conditioner
    Then Check that Air conditioner is avaliable

    When Click on the Interactive Flat
    Then Check that Interactive Flat is avaliable

    When Click on the Washing Machine
    Then Check that Washing Machine is avaliable

    When Click on the Refrigerator
    Then Check that Refrigerator is avaliable

    When Click on the Audio System
    Then Check that Audio System is avaliable

    When Click on the Smart Watch
    Then Check that Smart Watch is avaliable

    When Click on the Router
    Then Check that Router is avaliable
