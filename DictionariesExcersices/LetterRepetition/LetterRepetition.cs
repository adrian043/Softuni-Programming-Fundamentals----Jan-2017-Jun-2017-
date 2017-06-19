using System;
using System.Collections.Generic;

namespace LetterRepetition
{
    class LetterRepetition
    {
        public static void Main()
        {
            var word = Console.ReadLine().ToCharArray();
            var result = new Dictionary<char, int>();
            
            foreach (var item in word)
            {
                if (!result.ContainsKey(item))
                {
                    result[item] = 0;
                }
                result[item]++;
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}