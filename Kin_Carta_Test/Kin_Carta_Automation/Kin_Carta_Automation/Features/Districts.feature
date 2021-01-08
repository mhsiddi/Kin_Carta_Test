Feature: Districts
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


Scenario: As a user of the API I want to list all measurements taken by the station on Oak Street in json format.
	Given beach weather station sensor on 'Oak Street Weather Station'
	When the user requests station data
	Then all data measurements correspond to only that station

Scenario: As a user of the API I want to be able to page through json data sets of 2019 taken by the sensor on
"63rd Street"
	Given beach weather station sensor on '63rd Street Weather Station'
	And data is from '2019'
	When the user requests data for the first 10 measurements
	And the second page of 10 measurements
	Then the returned measurements of both pages should not repeat

Scenario: As a user of the API I expect a SQL query to fail with an error message if I search using a malformed query
	Given beach weather station sensor on '63rd Street Weather Station'	When the user requests sensor data by querying battery_life values that are less than the text 'full'	Then an error code 'malformed compiler' with message 'Could not parse SoQL query' is returned   