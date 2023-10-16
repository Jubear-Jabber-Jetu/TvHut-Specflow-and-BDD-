Feature: Category Link Verification

  Scenario: Verify category links navigate to the correct product category page
    Given the user is on the tvhut.com
    When the user clicks on the Television category link
    Then the user should be on the Television category page

    When the user clicks on the Air Conditioner category link
    Then the user should be on the Air Conditioner category page

    When the user clicks on the Interactive Flat category link
    Then the user should be on the Interactive Flat category page

    When the user clicks on the Washing Machine category link
    Then the user should be on the Washing Machine category page

    When the user clicks on the Refrigerator category link
    Then the user should be on the Refrigerator category page

    When the user clicks on the Audio System category link
    Then the user should be on the Audio System category page

    When the user clicks on the Smart Watch category link
    Then the user should be on the Smart Watch category page

    When the user clicks on the Router category link
    Then the user should be on the Router category page
