using System;
using System.Collections.Generic;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {

        char[] alph = new char[26];
        for (int i = 'a'; i <= 'z'; i++)
        {
            alph[i - 'a'] = (char) i;
        }

        var copy = input.ToLower();
        foreach (char letter in alph)
            if (!copy.Contains(letter))
            {
                return false;
            }
        return true;
    }
}
