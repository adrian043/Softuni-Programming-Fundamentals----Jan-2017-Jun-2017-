using System;

namespace AverageCharacterDelimiter
{
    class AverageCharacterDelimiter
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();
            int sum = 0;
            int charsCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                for (int k = 0; k < input[i].Length; k++)
                {
                    sum += (int)input[i][k];
                    charsCount++;
                }
            }

            char delimiter = (char)(sum / charsCount);
            string toUpper = delimiter.ToString().ToUpper();
            Console.WriteLine(string.Join(toUpper, input));
        }
    }
}