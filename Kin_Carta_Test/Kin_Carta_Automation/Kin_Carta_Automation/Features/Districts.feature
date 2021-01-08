Feature: Districts
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


Scenario: As a user of the API I want to list all measurements taken by the station on Oak Street in json format.
	Given beach weather station sensor “Oak Street Weather Station”
	When the user requests station data
	Then all data measuremeants correspond to only that station