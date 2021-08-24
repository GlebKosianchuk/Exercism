using System;

public static class Bob
{
    public static string Response(string statement)
    {
        var statemenntWithTrim = statement.Trim();
        var isUpperCase = statement.ToUpper();
        var isThereAnyLetters = ContainsLetter(statement);
        if (isUpperCase == statement && statement.EndsWith("?") && isThereAnyLetters)
            return "Calm down, I know what I'm doing!";

        if (statemenntWithTrim.EndsWith("?"))
            return "Sure.";

        if (string.IsNullOrWhiteSpace(statement))
            return "Fine. Be that way!";

        if (statement == isUpperCase && isThereAnyLetters)
            return "Whoa, chill out!";

        return "Whatever.";
    }
       private static  bool ContainsLetter(string statement)
        {
            foreach (var letter in statement)
                if (char.IsLetter(letter))
                    return true;
            return false;
        }
    
}
