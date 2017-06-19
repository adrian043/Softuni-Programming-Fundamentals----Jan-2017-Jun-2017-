using System;
using System.Globalization;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main()
        {
            var stringDate = Console.ReadLine();

            var date = DateTime.ParseExact(
                stringDate, 
                "d-M-yyyy", 
                CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}