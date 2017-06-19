using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TearListInHalf
{
    class TearListInHalf
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            var rightHalf = new List<int>();
            var leftHalf = new List<int>();
            var result = new List<int>();

            FillRightHalf(nums, rightHalf);
            FillLeftHalf(nums, leftHalf);
            AddInResult(rightHalf, leftHalf, result);

            Console.WriteLine(string.Join(" ", result));
        }    
        private static void FillLeftHalf(List<int> nums, List<int> leftHalf)
        {
            for (int i = 0; i < nums.Count / 2; i++)
            {
                leftHalf.Add(nums[i]);
            }
        }
        private static void FillRightHalf(List<int> nums, List<int> rightHalf)
        {
            for (int i = nums.Count / 2; i < nums.Count; i++)
            {
                rightHalf.Add(nums[i]);
            }
        }
        private static void AddInResult(List<int> rightHalf, List<int> leftHalf, List<int> result)
        {
            for (int i = 0; i < leftHalf.Count; i++)
            {
                result.Add(rightHalf[i] / 10);
                result.Add(leftHalf[i]);
                result.Add(rightHalf[i] % 10);
            }
        }
    }
}