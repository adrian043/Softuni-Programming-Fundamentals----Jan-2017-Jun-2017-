using System;
using System.Linq;

namespace RandomizeWords
{
    class RandomizeWords
    {
        static void Main()
        {
            var words = Console.ReadLine().Split().ToArray();
            var rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int k = rnd.Next(words.Length);

                var temp = words[i];
                words[i] = words[k];
                words[k] = temp;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}