Feature: DeletePet

A short summary of the feature

@tag1
Scenario: Delete a user using an ID
	Given User update payload
	When Send request to "DELETE" user when petid is "922337201690012700" 
	Then Validate status code is 200s
	And Close rest client
