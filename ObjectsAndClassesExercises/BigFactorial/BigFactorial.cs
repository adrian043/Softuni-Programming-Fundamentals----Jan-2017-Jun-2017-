using System;
using System.Numerics;

namespace BigFactorial
{
    class BigFactorial
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }

            Console.WriteLine(fact);
        }
    }
}