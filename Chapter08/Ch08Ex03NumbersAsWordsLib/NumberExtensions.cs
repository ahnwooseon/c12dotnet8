using System.Numerics;
using System.Text;

namespace Ch08Ex03NumbersAsWordsLib;

public static class NumberExtensions
{
    private static readonly string[] Units = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
    private static readonly string[] Teens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
    private static readonly string[] Dozens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

    public static string ToWords(this BigInteger number)
    {
        StringBuilder sb = new();

        Dictionary<int, string> thousandGroups = ToThousandGroups(number);
        Span<int> keys = thousandGroups.Keys.ToArray().AsSpan();
        keys.Reverse();
        foreach (int key in keys[0..^1])
        {
            if (thousandGroups[key] != "")
            {
                sb.Append($"{thousandGroups[key]} {((NumberNames)key).ToString().ToLower()}, ");
            }
        }
        if (thousandGroups[0] != "")
        {
            sb.Append($"and {thousandGroups[0]}");
        }

        return sb.ToString().TrimEnd(", ".ToCharArray());
    }

    public static string ToWords(this int number)
    {
        StringBuilder sb = new();

        int hundreds = number / 100;
        int dozens = number % 100 / 10;
        int units = number % 10;
        if (hundreds > 0)
        {
            sb.Append($"{Units[hundreds]} hundred");
        }
        if (dozens > 0)
        {
            if (hundreds > 0)
            {
                sb.Append(" and ");
            }
            sb.Append(dozens == 1 ? $"{Teens[units]}" : $"{Dozens[dozens]}");
        }
        if (dozens != 1 && units > 0)
        {
            if (dozens > 0 && units > 0)
            {
                sb.Append("-");
            }
            sb.Append($"{Units[units]}");
        }

        return sb.ToString();
    }

    private static Dictionary<int, string> ToThousandGroups(BigInteger number)
    {
        Dictionary<int, string> result = new();

        int power = 0;
        while (number > 0)
        {
            result.Add(power * 3, ((int)(number % 1000)).ToWords());
            number /= 1000;
            power++;
        }

        return result;
    }

    public enum NumberNames
    {
        None = 0,
        Thousand = 3,
        Million = 6,
        Billion = 9,
        Trillion = 12,
        Quadrillion = 15,
        Quintillion = 18,
    }
}
