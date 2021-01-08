# Kin_Carta_Test

Welcome to Kin Carta Tests!
Written By: Muhammad Siddiqui

The tools I have used for this project were the following:

1. Specflow
2. RestSharp
3. Visual Studio Unit Testing

Setup:

You should be able to restore the nugets, but if not:

1. Go to Manage Nuget Package
2. Install:
	-Specflow
	-Specflow for MSTest
	-RestSharp
	-NewtonSoft.Json
3. You might also need to add in "Specflow for Visual Studio" from the Visual Studio marketplace

To run tests:

1. Build the project
2. Go to test explorer and run tests as you please

Structure:

I like to organize my tests into the following areas:
1. Models: whatever data I'm going to serialize / deserialize
2. Features: whatever gherkins style feature file I'm going to write
3. Steps: whatever classes I'm going to implement my step definitions in 

My approach was to create a request and then verify that we get the data that we please.

Improvements I would make: 

1. Make this more data driven using Excel or Mocking framework
2. Improve wording of test cases so that we can reuse steps (I did this for scenarios 1/2)
