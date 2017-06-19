﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfWeek
{
    class DaysOfWeek
    {
        static void Main(string[] args)
        {
            string[] days = new string []{ "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int day = int.Parse(Console.ReadLine());

            if (day >= 1 && day <= 7)
            {
                Console.WriteLine(days[day-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
            

        }
    }
}
