using System;

public static class TwoFer
{
    // In order to get the tests running, first you need to make sure the Speak method 
    // can be called both without any arguments and also by passing one string argument.
    public static string Speak(string x=null)
    {
        string answer;
          string a=($"One for {x}, one for me.");
            string b=("One for you, one for me.");
             answer = x != null ? a:b;
               return (answer); 
        }
    }


