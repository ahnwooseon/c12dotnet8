int x = 0;
while (x < 10)
{
    WriteLine(x);
    x++;
}

// string? actualPassword = "Pa$$w0rd";
// string? password;
// int numberOfAttempts = 0;

// do
// {
//     Write("Enter your password: ");
//     password = ReadLine();
//     numberOfAttempts++;
// }
// while (password != actualPassword && numberOfAttempts < 3);

// if (numberOfAttempts < 3)
// {
//     WriteLine("Correct!");
// }
// else
// {
//     WriteLine("Maximum number of attempts exceeded.");
// }

for (int y = 1; y <= 10; y++)
{
    WriteLine(y);
}

for (var y = 0; y <= 10; y += 3)
{
    WriteLine(y);
}

string[] names = { "Adam", "Barry", "Charlie" };

foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}
