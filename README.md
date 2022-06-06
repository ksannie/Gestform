# Gestform

Framework : .NET 6.0
Tests : MSTest

Given a list of integers from -1000 to 1000, for each number write Geste, Forme, Gestform or the number depending on whether the number is a multiple of 3, 5, 3 and 5, or neither
## Structure of the project :


GestformRunner.cs : This is the main class that answer the problem. It contains a Run method that does exactly what is asked


GestformParser.cs : This class contains a TryParse method that given a string, return a success/fail boolean and fill a list of integers given in the parameters (the list is empty if the parsing failed)

Program.cs : The program is a console project, Program.cs ask for the user to enter a list of integers separated by commas, parse the input with GestformParser and run the algorithm with GestformRunner

The two classes GestformRunner and GestformParser both have a test class to avoid any regression, in case someone find this code so great they want to extend it...

## Run the project :
To test the program, enter
``` 
dotnet run
```
in the Gestform Folder, or simply build and run the project in Visual Studio
