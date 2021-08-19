using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        var uniqueMultiples = new List<int>();
        foreach (int uniqueMultiple in multiples)
        {
            var CurrentMultiple = 0;
            do
            {
                if (!uniqueMultiples.Contains(CurrentMultiple))
                {
                    uniqueMultiples.Add(CurrentMultiple);
                }

                CurrentMultiple += uniqueMultiple;
            } while (CurrentMultiple < max && CurrentMultiple != 0);
        }
        var sum = 0;
        foreach (int multiple in uniqueMultiples)
        {
            sum += multiple;
        }
        return sum;
    }
}
