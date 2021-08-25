Feature: JavaScript Alert tests



Background: 
Given user navigates to Javascript alert boxes page



Scenario: Checking if ok message is displayed
	When user clicks on the second button on the screen
	And click ok on the alert
	Then message contaning ok should be visible

Scenario: Checking if cancel message is displayed
	When user clicks on the second button on the screen
	And click cancel on the alert
	Then message contaning cancel should be visible

Scenario: Checking if Users name is displayed
	When user clicks on the bottom last button on the screen
	And enter his name in the prompt box
	Then message contaning Milovan should be visible


