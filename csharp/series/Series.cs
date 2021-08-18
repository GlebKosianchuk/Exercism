using System.Collections.Generic;
using System;
public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        var someList = new List<string>();
        var stroka = "";
            if(numbers.Length < sliceLength || sliceLength <= 0)
            throw new ArgumentException();
        for(var i = 0; i <= numbers.Length - sliceLength; i++)
        {
            for( var k = i; k < i + sliceLength; k++)
            {
                stroka += numbers[k];
            }
            someList.Add(stroka);
            stroka = "";
        }
        return someList.ToArray();
    }
}
