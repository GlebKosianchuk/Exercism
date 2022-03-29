using System;
using System.Collections.Generic;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        var i = 0;
        while (number != 1)
        {
            if (number == 0 || number < 0)
                throw new ArgumentOutOfRangeException();
            i += 1;
            number = number % 2 == 0 ? number / 2 : 3 * number + 1;
            continue;
        }
        return i;
    }
    
}