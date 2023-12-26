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

Person alice = new()
{
    Name = "Alice Jones",
    Born = new(1998, 3, 7, 16, 28, 0,
// This is an optional offset from UTC time zone.
TimeSpan.Zero)
};
WriteLine(format: "{0} was born on {1:d}.", // Short date.
    alice.Name, alice.Born);

bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
WriteLine(format: "{0}'s favorite wonder is {1}. Its integer is {2}.",
    bob.Name,
    bob.FavoriteAncientWonder,
    (int)bob.FavoriteAncientWonder);