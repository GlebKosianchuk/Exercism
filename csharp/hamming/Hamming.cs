using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length)
            throw new ArgumentException();

        var counter = 0;
        for (var i = 0; i < firstStrand.Length; i++)
        {
            if (firstStrand[i] != secondStrand[i])
                counter += 1;
        }
        return counter;
    }
}