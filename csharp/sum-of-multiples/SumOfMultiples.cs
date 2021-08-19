using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        var uniqueMultiples = new List<int>();
        foreach (int multiple in multiples)
        {
            var currentMultiple = 0;
            do
            {
                if (!uniqueMultiples.Contains(currentMultiple))
                {
                    uniqueMultiples.Add(currentMultiple);
                }

                currentMultiple += multiple;
            } while (currentMultiple < max && currentMultiple != 0);
        }

        var sum = 0;
        foreach (int multiple in uniqueMultiples)
        {
            sum += multiple;
        }
        return sum;
    }
}
