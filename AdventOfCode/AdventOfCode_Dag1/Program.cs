using System.Text.RegularExpressions;

namespace AdventOfCode_Dag1;

partial class Program
{
    static void Main(string[] args)
    {
        List<int> leftList = new();
        List<int> rightList = new();

        foreach (string line in File.ReadLines("input.txt"))
        {
            Match match = NumbersRegex().Match(line);

            int first = int.Parse(match.Groups["first"].Value);
            leftList.Add(first);

            int second = int.Parse(match.Groups["second"].Value);
            rightList.Add(second);
        }

        leftList.Sort();
        rightList.Sort();

        int result = 0;
        for (int i = 0; i < leftList.Count() ; i++)
        {
            result += leftList[i] * (rightList.Count(x => x == leftList[i]));
        }

        Console.WriteLine(result);
    }

    [GeneratedRegex(@"^(?<first>\d{5})\s{3}(?<second>\d{5})$")]
    private static partial Regex NumbersRegex();
}