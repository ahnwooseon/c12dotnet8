namespace Ch04Ex02PrimeFactorsLib;

public class PrimeFactors
{
    public List<int> Factorize(int n)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(n, nameof(n));

        List<int> result = new();

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            while (n % i == 0)
            {
                result.Add(i);
                n /= i;
            }
        }
        if (n > 2)
        {
            result.Add(n);
        }

        result.Reverse();

        return result;
    }
}
