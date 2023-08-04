Feature: UpdateUser

A short summary of the feature

@tag1
Scenario: Update user
	Given User update payload
	When Send request to "PUT" user when petid is "922337201690012700" 
	Then Validate status code is 200s
	And Close rest client
