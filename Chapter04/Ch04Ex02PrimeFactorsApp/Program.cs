using Ch04Ex02PrimeFactorsLib;
using static System.Console;

Write("""
* Prime Factors App *
Enter a number: 
""");
string number = ReadLine()!;

ArgumentException.ThrowIfNullOrWhiteSpace(number, nameof(number));

List<int> primeFactors = new PrimeFactors().Factorize(int.Parse(number));

WriteLine($"The prime factors of {number} are: {string.Join(", ", primeFactors)}");
