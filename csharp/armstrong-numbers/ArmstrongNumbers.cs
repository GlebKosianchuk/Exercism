using System;
using System.Collections.Generic;
public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        var numberr = number;
        var ListOfNumbers = new List<int>();
        var i = 0;
        double numbersInDegree = 0;

        while (numberr % 10 > 0)
        {
            numberr /= 10;
            i += 1;
        }

        foreach (var numbers in number.ToString())
            ListOfNumbers.Add(int.Parse(numbers.ToString()));

        foreach (var numbers in ListOfNumbers)
            numbersInDegree += Math.Pow(numbers, i);

       return  numbersInDegree == number || numbersInDegree == 1;
    }
}