using System.Globalization;

namespace LeapYear_Calculator
{
    public class Year
    {
        public static bool CheckLeapYear(int year)
        {
            if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int GetDayNumber(DateTime date)
        {
            return date.DayOfYear;
        }

        public static int GetWeekOfTheYear(DateTime date)
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(date);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                date = date.AddDays(3);
            }

            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        public static string GetWeekDay(DateTime date)
        {
            return date.DayOfWeek.ToString();
        }

    }
}