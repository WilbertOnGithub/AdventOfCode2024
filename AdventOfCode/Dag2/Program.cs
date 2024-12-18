using System.Collections.ObjectModel;

namespace Dag2;

class Program
{
    static void Main(string[] args)
    {
        int safeReports = 0;
        List<ReportCollection> badReports = new();
        foreach (string line in File.ReadLines("input.txt"))
        {
            var report = new ReportCollection(line.Split(' ').Select(x => int.Parse(x)).ToList());
            if (report.IsSafeReport())
            {
                safeReports++;
            }
            else
            {
                badReports.Add(report);
            }
        }

        // Walk through all badReports
        safeReports += badReports.Count(report => report.ReportCanBeMadeSafe());

        Console.WriteLine(safeReports);
    }

}