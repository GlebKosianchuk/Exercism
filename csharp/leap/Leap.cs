public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        bool mainrule = year % 4 == 0;
        bool divisionby100withremainer = year % 100 != 0;
        bool divisionby100withoutremainer = year % 100 == 0;
        bool divisionby400withoutremainer = year % 400 == 0;
        return ((mainrule && divisionby100withremainer) || (divisionby100withoutremainer && divisionby400withoutremainer));
    }
}