using Packt.Shared; // To use Person.

ConfigureConsole("fr-FR"); // Sets current culture to US English.

// Alternatives:
// ConfigureConsole(useComputerCulture: true); // Use your culture.
// ConfigureConsole(culture: "fr-FR"); // Use French culture.

// Person bob = new Person(); // C# 1 or later.
// var bob = new Person(); // C# 3 or later.
Person bob = new(); // C# 9 or later.
WriteLine(bob); // Implicit call to ToString().
// WriteLine(bob.ToString()); // Does the same thing.

bob.Name = "Bob Smith";

bob.Born = new DateTimeOffset(
    1965, 12, 22,
    16, 28, 0,
    TimeSpan.FromHours(-5)); // US Eastern Standard Time

WriteLine("{0} was born on {1:D}",
    bob.Name, bob.Born);
