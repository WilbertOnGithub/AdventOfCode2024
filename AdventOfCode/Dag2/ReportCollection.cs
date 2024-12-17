using System.Collections.ObjectModel;

namespace Dag2;

public class ReportCollection : Collection<int>
{
    public void foo()
    {
        var ascendingCopy = new List<int>(Items).OrderBy(x => x);
        var descendingCopy = new List<int>(Items).OrderByDescending(x => x);

        if (ascendingCopy.SequenceEqual(Items))
        {
            Console.WriteLine("Ascending");
        }
        else if (descendingCopy.SequenceEqual(Items))
        {
            Console.WriteLine("Descending");
        }
}