public static class Raindrops
{
    public static string Convert(int number)
    {
        var factorToRaindrop = new (int digit, string raindrop)[]
        {
            (3, "Pling"),
            (5, "Plang"),
            (7, "Plong")
        };
        var result = "";

        foreach(var (factor, raindrop) in factorToRaindrop)
        {
            if (number % factor == 0)
                result += raindrop;
        }

        return result == "" ? number.ToString() : result;
    }
}