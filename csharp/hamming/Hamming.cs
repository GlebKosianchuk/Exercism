using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
    var collector = 0;
        {
            if (firstStrand.Length > secondStrand.Length)
            throw new ArgumentException();
        }
        {
            if (firstStrand.Length < secondStrand.Length)
            throw new ArgumentException();
        }
        {
            if ( firstStrand == "" && firstStrand.Length < secondStrand.Length)
            throw new ArgumentException();
        }
        {
             if ( secondStrand == "" && firstStrand.Length > secondStrand.Length)
            throw new ArgumentException();
        }
            for (var i=0;i<=firstStrand.Length-1;i++)
            {
                if (firstStrand[i] != secondStrand[i])
                collector=collector + 1;
            }
            return collector;
    }
}