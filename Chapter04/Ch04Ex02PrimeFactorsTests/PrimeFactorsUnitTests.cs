using Ch04Ex02PrimeFactorsLib;

namespace Ch04Ex02PrimeFactorsTests;

public class PrimeFactorsUnitTests
{
    [Fact]
    public void TestPrimeFactorsOf4()
    {
        // Arrange
        PrimeFactors sut = new();
        List<int> expected = new List<int> { 2, 2 };

        // Act
        List<int> actual = sut.Factorize(4);

        // Assert
        Assert.True(expected.All(actual.Contains));
    }

    [Fact]
    public void TestPrimeFactorsOf7()
    {
        // Arrange
        PrimeFactors sut = new();
        List<int> expected = new List<int> { 7 };

        // Act
        List<int> actual = sut.Factorize(7);

        // Assert
        Assert.True(expected.All(actual.Contains));
    }

    [Fact]
    public void TestPrimeFactorsOf30()
    {
        // Arrange
        PrimeFactors sut = new();
        List<int> expected = new List<int> { 5, 3, 2 };

        // Act
        List<int> actual = sut.Factorize(30);

        // Assert
        Assert.True(expected.All(actual.Contains));
    }

    [Fact]
    public void TestPrimeFactorsOf40()
    {
        // Arrange
        PrimeFactors sut = new();
        List<int> expected = new List<int> { 5, 2, 2, 2 };

        // Act
        List<int> actual = sut.Factorize(40);

        // Assert
        Assert.True(expected.All(actual.Contains));
    }

    [Fact]
    public void TestPrimeFactorsOf50()
    {
        // Arrange
        PrimeFactors sut = new();
        List<int> expected = new List<int> { 5, 5, 2 };

        // Act
        List<int> actual = sut.Factorize(50);

        // Assert
        Assert.True(expected.All(actual.Contains));
    }
}
