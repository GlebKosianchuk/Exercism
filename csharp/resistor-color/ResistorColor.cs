using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        var colors = Colors();
        for (var i = 0; i <= 9; i++)
        {
            if (colors[i] == color)
                return(i);
        }
        return -1;
    }

    public static string[] Colors()
    {
        return new string[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
    }
}