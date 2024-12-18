using System.Collections.ObjectModel;

namespace Dag2;

public class ReportCollection : Collection<int>
{
    public ReportCollection(IEnumerable<int> items) : base(items.ToList())
    {
    }

    public bool IsSafeReport()
    {
        var ascendingCopy = new List<int>(Items).OrderBy(x => x);
        var descendingCopy = new List<int>(Items).OrderByDescending(x => x);

        if (ascendingCopy.SequenceEqual(Items) || descendingCopy.SequenceEqual(Items))
        {
            for (int i = 0; i < Items.Count - 1; i++)
            {
                int diff = Math.Abs(Items[i] - Items[i + 1]);
                if (diff is < 1 or > 3) return false;
            }
            return true;
        }
        return false;
    }

    public bool ReportCanBeMadeSafe()
    {
        // 1 3 2 4 5
        int toRemove = 0;
        for (int i = 0; i < Items.Count - 1; i++)
        {
            int diff = Math.Abs(Items[i] - Items[i + 1]);
            if (diff is < 1 or > 3)
            {
                toRemove = Items[i + 1];
                break;
            }
        }

        Items.Remove(toRemove);

        for (int i = 0; i < Items.Count - 1; i++)
        {
            int diff = Math.Abs(Items[i] - Items[i + 1]);
            if (diff is < 1 or > 3) return false;
        }

        return true;
    }
}