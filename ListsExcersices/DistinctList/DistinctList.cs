using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctList
{
    class DistinctList
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            for (int i = 0; i < nums.Count; i++)
            {                
                for (int k = 1 + i; k < nums.Count; k++)
                {
                    if (nums[i] == nums[k])
                    {
                        nums.RemoveAt(k);
                        k--;                                       
                    }                  
                } 
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
