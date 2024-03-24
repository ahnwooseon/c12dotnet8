int numberOfApples = 12;
decimal pricePerApple = 0.35M;

Console.WriteLine(
    "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

string formatted = string.Format(
    "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

//WriteToFile(formatted); // Writes the string into a file.

// Three parameter values can use named arguments.
Console.WriteLine("{0} {1} lived in {2}.", arg0: "Roger", arg1: "Cevung", arg2: "Stockholm");
// Four or more parameter values cannot use named arguments.
Console.WriteLine("{0} {1} lived in {2} and worked in the {3} team at {4}.", "Roger", "Cevung", "Stockholm", "Education", "Optimizely");

// The following statement must be all on one line when using C# 10 // or earlier. If using C# 11 or later, we can include a line break // in the middle of an expression but not in the string text.
Console.WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");

string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;

Console.WriteLine();

Console.WriteLine("{0,-10} {1,6}", arg0: "Name", arg1: "Count");

Console.WriteLine("{0,-10} {1,6:N0}", arg0: applesText, arg1: applesCount);

Console.WriteLine("{0,-10} {1,6:N0}", arg0: bananasText, arg1: bananasCount);
