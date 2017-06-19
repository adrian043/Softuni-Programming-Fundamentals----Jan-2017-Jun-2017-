using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelsBack
{
    class CamelsBack
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            int end = nums.Count - 1;
            int length = nums.Count;
            int counter = 0;
            bool isStable = false;

            if (n == length)
            {
                isStable = true;
            }

            while (n != length)
            {
                nums.RemoveAt(nums.Count - 1);
                nums.RemoveAt(0);   
                end-=2;
                length -= 2;
                counter++;
            }
            
            if (isStable)
            {
                Console.WriteLine($"already stable: {string.Join(" ", nums)}");
            }
            else
            {
                Console.WriteLine($"{counter} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", nums)}");
            }            
        }
    }
}
