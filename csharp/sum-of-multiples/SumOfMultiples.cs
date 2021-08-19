using System.Collections.Generic;
public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        var listForSumOperation = new List<int>();
        var sum = 0;
        foreach (int operand in multiples)
        {
            var result = 0;
            do
            {
                if (!listForSumOperation.Contains(result))
                {
                    listForSumOperation.Add(result);
                }

                result += operand;
            } while (result < max && result != 0);
        }

        foreach (int multipless in listForSumOperation)
        {
            sum += multipless;
        }
        return sum;
    }
}
