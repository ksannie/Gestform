using Gestform;

string userInput;
var gestformParser = new GestformParser();
List<int> numbers;
do
{
    Console.WriteLine("Enter a list of integers between -1000 and 1000 included, separated by commas: \",\"");
    userInput = Console.ReadLine();
} while (userInput == null || !gestformParser.TryParse(userInput, out numbers));

var gestformRunner = new GestformRunner();
gestformRunner.Run(numbers);
