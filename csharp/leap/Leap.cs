public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        var divisionBy4WithOutRemainder = year % 4 == 0;
        var divisionBy100WithRemainder = year % 100 != 0;
        var divisionBy400WithOutRemainder = year % 400 == 0;
        return (divisionBy4WithOutRemainder && divisionBy100WithRemainder) || divisionBy400WithOutRemainder;
    }
}