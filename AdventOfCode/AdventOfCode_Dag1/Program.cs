using System.Text.RegularExpressions;

namespace AdventOfCode_Dag1;

partial class Program
{
    static void Main(string[] args)
    {
        List<int> firstList = new();
        List<int> secondList = new();

        foreach (string line in File.ReadLines("input.txt"))
        {
            Match match = NumbersRegex().Match(line);

            int first = int.Parse(match.Groups["first"].Value);
            firstList.Add(first);

            int second = int.Parse(match.Groups["second"].Value);
            secondList.Add(second);
        }

        firstList.Sort();
        secondList.Sort();

        int result = 0;
        for (int i = 0; i < firstList.Count() ; i++)
        {
            result += Math.Abs(firstList[i] - secondList[i]);
        }

        Console.WriteLine(result);
    }

    [GeneratedRegex(@"^(?<first>\d{5})\s{3}(?<second>\d{5})$")]
    private static partial Regex NumbersRegex();
}