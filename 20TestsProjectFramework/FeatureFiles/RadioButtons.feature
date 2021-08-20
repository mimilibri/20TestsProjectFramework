Feature: RadioButtons
	Test the radio buttons in different scenarios
Background:
	Given i was on home page
	When i navigate to testpage and dismiss banner
	And i click the link to radiobuttons page
	Then radiobutton labeled male should be visible

Scenario: Click on male radiobutton, then Getvalue button and check if displayed message is correct
	
	When I click on Male labeled radiobutton
	And i click on GetCheckedValue button
	Then message contaning string Male should be viisible


Scenario: Click ond male and 0to5 radiobuttons, submit, and check if displayed message is correct 

	When i click on second male labeled radiobutton
	And i click on the age radiobutton
	And i click get values button
	Then right display message should be displayed

Scenario: dont click any radiobuttons, and check if displayed message contains any of following words:
-Male
-Female
-0 - 5
-5 - 15
-15 - 50

	When i click get values button
	Then Check if message does not contain words above



