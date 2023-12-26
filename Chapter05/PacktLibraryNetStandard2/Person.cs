// ALL types in this file will be defined in this file-scoped namespace.
namespace Packt.Shared;

public class Person : object
{
    #region Fields: Data or state for this person.

    // Constant fields: Values that are fixed at compilation.
    public const string Species = "Homo Sapiens";

    public string? Name; // ? means it can be null.
    public DateTimeOffset Born;
    public WondersOfTheAncientWorld FavoriteAncientWonder;
    public WondersOfTheAncientWorld BucketList;
    public List<Person> Children = new();

    #endregion
}
