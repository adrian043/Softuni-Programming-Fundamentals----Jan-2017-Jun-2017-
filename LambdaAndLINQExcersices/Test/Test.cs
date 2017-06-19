using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Test
    {              
        public static void Main()
        {
            var list = new Dictionary<string, List<int>>();
            var key = Console.ReadLine();

            list[key] = new List<int>();

            list[key].Add(5);
            list[key].Add(1);
            list[key].Add(2);
            list[key].Add(7);
            list[key].Add(9);

            var result = list
                .SelectMany(x => x.Value)
                .Where(x => x > 4);

            Console.WriteLine(string.Join(" ", result));
        }   
    }
}   