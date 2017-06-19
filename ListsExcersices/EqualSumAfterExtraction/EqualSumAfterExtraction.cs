using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSumAfterExtraction
{
    class EqualSumAfterExtraction
    {
        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var secondInput = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sumFirstInput = 0;
            int sumSecondInput = 0;

            for (int i = 0; i < firstInput.Count; i++)
            {
                for (int k = 0; k < secondInput.Count; k++)
                {
                    if (firstInput[i] == secondInput[k])
                    {
                        secondInput.Remove(secondInput[k]);
                    }
                }
            }

            if (firstInput.Sum() == secondInput.Sum())
            {
                Console.WriteLine($"Yes. Sum: {secondInput.Sum()}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(secondInput.Sum() - firstInput.Sum())}");
            }
        }
    }
}
