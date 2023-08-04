Feature: CreatePet

@mytag
Scenario: Create new pet
	Given User update payload
	When Send request to "POST" user when petid is "922337201690012700" 
	Then Validate status code is 200s
	And Close rest client