string[] names; // This can reference any size array of strings.

// Allocate memory for four strings in an array.
names = new string[4];

// Store items at these index positions.
names[0] = "Kate";
names[1] = "Jack";
names[2] = "Rebecca";
names[3] = "Tom";

string[] names2 = { "Kate", "Jack", "Rebecca", "Tom" };

// Loop through the names.
for (int i = 0; i < names2.Length; i++)
{
    // Output the item at index position i.
    WriteLine($"{names2[i]} is at position {i}.");
}

string[,] grid1 = // Two dimensional array.
{
    { "Alpha", "Beta", "Gamma", "Delta" },
    { "Anne", "Ben", "Charlie", "Doug" },
    { "Aardvark", "Bear", "Cat", "Dog" }
};
WriteLine($"1st dimension, lower bound: {grid1.GetLowerBound(0)}");
WriteLine($"1st dimension, upper bound: {grid1.GetUpperBound(0)}");
WriteLine($"2nd dimension, lower bound: {grid1.GetLowerBound(1)}");
WriteLine($"2nd dimension, upper bound: {grid1.GetUpperBound(1)}");

for (int row = 0; row <= grid1.GetUpperBound(0); row++)
{
    for (int col = 0; col <= grid1.GetUpperBound(1); col++)
    {
        WriteLine($"Row {row}, Column {col}: {grid1[row, col]}");
    }
}
