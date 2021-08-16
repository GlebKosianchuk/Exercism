using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length)
            throw new ArgumentException();
            
        var collector = 0;
        for (var i = 0; i <= firstStrand.Length-1; i++)
        {
            if (firstStrand[i] != secondStrand[i])
                collector = collector + 1;
        }
        return collector;
    }
}