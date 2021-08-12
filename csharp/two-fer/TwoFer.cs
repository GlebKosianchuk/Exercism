public static class TwoFer
{
public static string Speak ( string name=null)
    {
     var x= name!=null ?  $"{name}":"you";
       return $"One for {x}, one for me."; 
    }
}