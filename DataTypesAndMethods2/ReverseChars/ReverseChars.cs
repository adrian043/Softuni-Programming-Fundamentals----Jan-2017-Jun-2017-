using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;

            if (GetMax(num1, num2)<num3)
            {
                maxNum = num3;
            }
            else
            {
                maxNum = GetMax(num1, num2);
            }

            Console.WriteLine(maxNum);
        }

        static int GetMax(int a, int b)
        {
            int maxVal = int.MinValue;
            if (maxVal < a)
            {
                maxVal = a;
                if (maxVal < b)
                {
                    maxVal = b;
                }
            }
            return maxVal;
        }
    }
}
