using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        var isUpperCase = statement.ToUpper();
        var hasLetter = statement.Any(s => char.IsLetter(s));
        if (isUpperCase == statement && statement.EndsWith("?") && hasLetter)
            return "Calm down, I know what I'm doing!";

        if (statement.Trim().EndsWith("?"))
            return "Sure.";

        if (string.IsNullOrWhiteSpace(statement))
            return "Fine. Be that way!";

        if (statement == isUpperCase && hasLetter)
            return "Whoa, chill out!";

        return "Whatever.";
    }
}
