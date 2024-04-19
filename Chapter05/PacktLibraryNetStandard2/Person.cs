// All types in this file will be defined in this file-scoped namespace.
namespace Packt.Shared;

public class Person : object
{
    // Constant fields: Values that are fixed at compilation.
    public const string Species = "Homo Sapiens";
    // Read-only fields: Values that can be set at runtime.
    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantiated;

    #region Fields: Data or state for this person.

    public string? Name; // ? means it can be null.
    public DateTimeOffset Born;
    public WondersOfTheAncientWorld FavoriteAncientWonder;
    public WondersOfTheAncientWorld BucketList;
    public List<Person> Children = new();

    #endregion

    #region Constructors: Called when using new to instantiate a type.

    public Person()
    {
        // Constructors can set default values for fields
        // including any read-only fields like Instantiated.
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }

    public Person(string initialName, string homePlanet)
    {
        Name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }

    #endregion

    #region Methods: Actions the type can perform.

    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {Born:dddd}.");
    }

    public string GetOrigin()
    {
        return $"{Name} was born on {HomePlanet}.";
    }

    public string SayHello()
    {
        return $"{Name} says 'Hello!'";
    }

    public string SayHelloTo(string name)
    {
        return $"{Name} says 'Hello, {name}!'";
    }

    #endregion
}
