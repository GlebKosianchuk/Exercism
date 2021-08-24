using System;
using System.Collections.Generic;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if(numbers.Length < sliceLength || sliceLength <= 0)
            throw new ArgumentException();

        var someList = new List<string>();
        for(var i = 0; i <= numbers.Length - sliceLength; i++)
        {
            var series = "";
            for(var k = i; k < i + sliceLength; k++)
            {
                series += numbers[k];
            }
            someList.Add(series);
        }
        return someList.ToArray();
    }
}
