using System.Text.RegularExpressions; // To use Regex.

Write("Enter your age: ");
string input = ReadLine()!; // Null-forgiving operator.
Regex ageChecker = new(@"^\d+$");
WriteLine(ageChecker.IsMatch(input) ? "Thank you!" : $"This is not a valid age: {input}");
