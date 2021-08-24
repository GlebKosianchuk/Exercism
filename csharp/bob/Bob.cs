using System;

public static class Bob
{
    public static string Response(string statement)
    {
        var statemenntWithTrim = statement.Trim();
        var copytToUpper = statement.ToUpper();

        if (copytToUpper == statement && statement.EndsWith("?") && IsStringContainsLetter(statement))
            return "Calm down, I know what I'm doing!";

        if (statemenntWithTrim.EndsWith("?"))
            return "Sure.";

        if (statemenntWithTrim == "")
            return "Fine. Be that way!";

        if (statement == copytToUpper && IsStringContainsLetter(statement))
            return "Whoa, chill out!";

        return "Whatever.";
    }
       public static  bool IsStringContainsLetter(string statement)
        {
            foreach (var letter in statement)
                if (char.IsLetter(letter))
                    return true;
            return false;
        }
    
}
