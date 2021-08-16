using System.Text;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        StringBuilder letters = new StringBuilder ("");
        for(var i = input.Length - 1; i >= 0; i--)
        {
            letters.Append(input[i]);
        }
        return letters.ToString();
    }
}