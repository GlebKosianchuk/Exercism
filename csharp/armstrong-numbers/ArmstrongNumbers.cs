using System;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        var sumOfPowers = 0;
        var numberToString = number.ToString();
        var countOfDigits = numberToString.Length;

        foreach (var digit in number.ToString())
            sumOfPowers += (int) Math.Pow(int.Parse(digit.ToString()), countOfDigits);

        return sumOfPowers == number ;
    }
}