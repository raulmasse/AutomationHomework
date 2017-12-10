Feature: Homework
	The following requirements are given for http://uitest.duodecadits.com website.

Scenario: 01_Home Page
REQ-UI-01, RE1-UI-02, REQ-UI-03, REQ-UI-04, REQ-UI-09, REQ-UI-10
	Given I'm on the duodecad site
	When I click on the Home button
	Then I should get navigated to the Home page
		And Home button should turn to active status
		And The Title should be UI Testing Site
		And The Company Logo should be visible
		And Welcome to the Docler Holding QA Department should be visible in h
		And This site is dedicated to perform some exercises and demonstrate automated web testing in p

Scenario: 02_Form Page
REQ-UI-01, RE1-UI-02, REQ-UI-05, REQ-UI-06, REQ-UI-11
	Given I'm on the duodecad site
	When I click on the Form button
	Then I should get navigated to the Form page
		And Form button should turn to active status
		And The Title should be UI Testing Site
		And The Company Logo should be visible
		And a form should be visible with one input box and one submit button

Scenario: 03_Error Page
REQ-UI-07
	Given I'm on the duodecad site
	When I click on the Error Button
	Then I should get a 404 HTTP response code

Scenario: 04_UI Testing Button
REQ-UI-01, RE1-UI-02, REQ-UI-08, REQ-UI-09, REQ-UI-10
	Given I'm on the duodecad site
	When I click on the UI Testing button
	Then I should get navigated to the Home page
		And The Title should be UI Testing Site
		And The Company Logo should be visible
		And Welcome to the Docler Holding QA Department should be visible in h
		And This site is dedicated to perform some exercises and demonstrate automated web testing in p

Scenario Outline: 05_Form Input
REQ-UI-01, RE1-UI-02, REQ-UI-08, REQ-UI-12
	Given I'm on the Form page
	When I type <value> and click submit
	Then should get redirected to the Hello page
	And The Title should be UI Testing Site
	And The Company Logo should be visible
	And <result> should appear

	Examples: 
	| value   | result         |
	| John    | Hello John!    |
	| Sophia  | Hello Sophia!  |
	| Charlie | Hello Charlie! |
	| Emily   | Hello Emily!   |
