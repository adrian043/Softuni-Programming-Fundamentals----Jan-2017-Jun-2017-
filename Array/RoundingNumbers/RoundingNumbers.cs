using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbers
{
    class RoundingNumbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            foreach (var num in nums)
            {
                var rounded = (long)(num + 0.5);
                Console.WriteLine(rounded);
            }
        }
    }
}
