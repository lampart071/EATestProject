Feature: Employee
	Responsible for verfiying Benefits, Create Employee,
	Delete employee and check if the functionality works


@smoke
Scenario: Create Employee with all details
	Given I have navigated to the application
	And I see application opened
	Then I click login link
	When I enter UserName and Password
	| UserName | Password |
	| admin    | password |
	Then I click login button
	And I click employeeList link
	Then I click createnew button
	And I enter following details
	| Name     | Salary | DurationWorked | Grade | Email           |
	| AutoUser | 4000   | 30             | 1     | autouser@ea.com |
	And I click create button
