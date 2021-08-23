public static class Pangram
{
    public static bool IsPangram(string input)
    {
        const string alphabet = "abcdefghijklmnopqrstuvwxyz";
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
