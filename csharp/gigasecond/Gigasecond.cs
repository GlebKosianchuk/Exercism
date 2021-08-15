using System;
public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        long gigasecond = 1000000000;
        var sum = moment.AddSeconds(gigasecond);
        return sum;
    }
}