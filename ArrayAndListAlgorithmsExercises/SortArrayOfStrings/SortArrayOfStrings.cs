using System;
using System.Linq;

namespace SortArrayOfStrings
{
    class SortArrayOfStrings
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            bool swapped;

            do
            {
                swapped = false;
                for (int i = 0; i < input.Length - 1; i++)
                {
                    if (input[i].CompareTo(input[i].ToString()) > input[i + 1].CompareTo(input[i].ToString()))
                    {
                        var temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;

                        swapped = true;
                    }
                }
            } while (swapped);

            Console.WriteLine(string.Join(" ", input));
        }
    }
}