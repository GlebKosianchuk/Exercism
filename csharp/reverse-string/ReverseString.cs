using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        string letters = "";
        for(var i = input.Length - 1; i >= 0; i --)
        {
            letters += input[i];
        }
        return letters;
    }
}