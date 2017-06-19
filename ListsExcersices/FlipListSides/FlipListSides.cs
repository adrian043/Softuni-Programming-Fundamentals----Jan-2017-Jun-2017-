using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipListSides
{
    class FlipListSides
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //var result = new List<int>();
            //result.Add(nums[0]);          
            //for (int i = nums.Count - 2; i >= 0; i--)
            //{
            //    result.Add(nums[i]);                   
            //}
            //result[result.Count - 1] = nums[nums.Count - 1];
            //Console.WriteLine(string.Join(" ", result));
            nums.Reverse();
            int temp = nums[0];
            nums[0] = nums[nums.Count - 1];            
            nums[nums.Count - 1] = temp;
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
