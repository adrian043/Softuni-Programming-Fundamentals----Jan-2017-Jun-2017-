using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {            
            string[] words1 = Console.ReadLine().Split(' ');
            string[] words2 = Console.ReadLine().Split(' ');
            var rightCount = 0;

            while (rightCount < words1.Length &&
                    rightCount < words2.Length)
                if (words1[words1.Length - rightCount - 1] ==
                        words2[words2.Length - rightCount - 1])
                    rightCount++;
                else break;
            Console.WriteLine(rightCount); 
            
        }
    }
}
