using System;
using System.Collections.Generic;

namespace MixedPhones
{
    class MixedPhones
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var result = new SortedDictionary<string, long>();

            while (input[0] != "Over")
            {
                long n = 0;
                bool isNum = long.TryParse(input[0], out n);

                if (isNum)
                {
                    result[input[2]] = long.Parse(input[0]);
                }
                else
                {
                    result[input[0]] = long.Parse(input[2]);
                }

                input = Console.ReadLine().Split();
            }
            
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}