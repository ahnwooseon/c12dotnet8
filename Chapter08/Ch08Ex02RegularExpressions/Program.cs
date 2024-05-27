using System.Text.RegularExpressions;

WriteLine("The default regular expression checks for at least one digit.");

do
{
    Check();
}
while (ReadKey().Key != ConsoleKey.Escape);
WriteLine();

void Check()
{
    Write("Enter a regular expression (or press ENTER to use the default): ");
    string regex = @$"{ReadLine()}";
    if (string.IsNullOrWhiteSpace(regex)) regex = @"^[a-z]+$";
    Write("Enter some input: ");
    string input = ReadLine();
    WriteLine($"{input} matches {regex}? {new Regex(regex).IsMatch(input)}");
    Write("Press ESC to end or any key to try again.");
}
