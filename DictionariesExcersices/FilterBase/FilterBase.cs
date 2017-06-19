using System;
using System.Collections.Generic;

namespace FilterBase
{
    class FilterBase
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var resultPosition = new Dictionary<string, string>();            
            var resultAge = new Dictionary<string, int>();
            var resultSalary = new Dictionary<string, double>();
            bool filterBase = false;
            int n = 0;
            double d = 0;

            while (input != "filter base")
            {
                var tokens = input.Split(new char[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0];
                var secondLine = tokens[1];
                int age = 0;
                double salary = 0;
                string position = string.Empty;
                bool isAge = int.TryParse(secondLine, out n);
                bool isSalary = double.TryParse(secondLine, out d);
                bool isPosition = secondLine is string;
                
                if (isAge)
                {
                    age = int.Parse(secondLine);
                    resultAge[name] = age;
                }
                else if (isSalary)
                {
                    salary = double.Parse(secondLine);
                    resultSalary[name] = salary;
                }
                else if (isPosition)
                {
                    position = secondLine;
                    resultPosition[name] = position;
                }     

                input = Console.ReadLine();
            }
            input = Console.ReadLine();

            if (input == "Age")
            {
                foreach (var item in resultAge)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Age: {item.Value}");
                    Console.WriteLine("====================");
                }
                
            }
            else if (input == "Salary")
            {
                foreach (var item in resultSalary)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Salary: {item.Value:f2}");
                    Console.WriteLine("====================");
                }
            }
            else if (input == "Position")
            {
                foreach (var item in resultPosition)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Position: {item.Value}");
                    Console.WriteLine("====================");
                }                
            }            
        }
    }
}