Write("Enter a number between 0 and 255: ");
string number = ReadLine()!;
Write("Enter another number between 0 and 255: ");
string anotherNumber = ReadLine()!;

try
{
    byte parsedNumber = byte.Parse(number);
    int parsedAnotherNumber = int.Parse(anotherNumber);
    WriteLine($"{number} divided by {anotherNumber} is {parsedNumber / parsedAnotherNumber}");
}
catch (Exception e)
{
    WriteLine($"{e.GetType().Name}: {e.Message}");
}
