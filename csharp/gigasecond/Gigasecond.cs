using System;
public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        var gigasecond = 1000000000;
        var timeAfteraGigasecond = moment.AddSeconds(gigasecond);
        return timeAfteraGigasecond;
    }
}