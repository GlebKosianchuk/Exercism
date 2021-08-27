using System;

public static class Raindrops
{
    public static string Convert(int number)
    {
        string resultString = "";
        if (number % 3 == 0)
            resultString += "Pling";
        if (number % 5 == 0)
            resultString += "Plang";
        if (number % 7 == 0)
            resultString += "Plong";
        if (resultString == "")
            resultString = number.ToString();
        return resultString;
       
    }
}