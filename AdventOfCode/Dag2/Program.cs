using System.Collections.ObjectModel;

namespace Dag2;

class Program
{
    static void Main(string[] args)
    {
        foreach (string line in File.ReadLines("input.txt"))
        {
            ReportCollection report = new ReportCollection();
            foreach (var number in line.Split(' '))
            {
                report.Add(int.Parse(number));
            }
        }
    }

}