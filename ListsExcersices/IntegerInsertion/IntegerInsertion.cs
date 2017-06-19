using System;
using System.Linq;

namespace IntegerInsertion
{
    class IntegerInsertion
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var num = int.Parse(inputLine);
                var firstDigit = findFirstDigit(num);

                for (int i = 0; i < nums.Count; i++)
                {
                    if (firstDigit == i)
                    {
                        nums.Insert(i, num);
                    }
                }
                inputLine = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", nums));
        }
        private static int findFirstDigit(int num)
        {
            int firstDigit = num % 10;
            while (num > 0)
            {
                firstDigit = num % 10;
                num /= 10;
            }
            return firstDigit;
        }
    }
}