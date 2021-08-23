public static class Pangram
{
    public static bool IsPangram(string input)
    {
        var alphabet = new char[26];
        for (var i = 'a'; i <= 'z'; i++)
        {
            alphabet[i - 'a'] = (char) i;
        }

        var inputInLower = input.ToLower();
        foreach (var letter in alphabet)
        {
            if (!inputInLower.Contains(letter))
            {
                return false;

            }
        }
        return true;
    }
}
