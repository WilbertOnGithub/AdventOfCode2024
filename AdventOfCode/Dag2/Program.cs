using System.Collections.ObjectModel;

namespace Dag2;

class Program
{
    static void Main(string[] args)
    {
        int safeReports = 0;
        foreach (string line in File.ReadLines("input.txt"))
        {
            var report = new ReportCollection(line.Split(' ').Select(x => int.Parse(x)).ToList());
            if (report.safeReport())
            {
                safeReports++;
            }
        }
        Console.WriteLine(safeReports);
    }

}