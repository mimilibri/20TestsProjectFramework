Feature: SpecFlowFeature1
	Simple calculator for adding two numbers
Background:
Given i was on home page

Scenario: radiobuttons
	When i navigate to testpage and dismiss banner
	And i click the link to radiobuttons page
	Then radiobutton labeled male should be visible
	When I click on Male labeled radiobutton
	And i click on GetCheckedValue button
	Then message contaning string Male should be viisible
