using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayHistogram
{
    class ArrayHistogram
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();
            var words = new List<string>();
            var occurrences = new List<int>();

            foreach (var item in input)
            {
                if(!words.Contains(item))
                {
                    words.Add(item);
                }

                int wordsIndex = input.IndexOf(item);
                occurrences.Add(wordsIndex);


            }
            //Console.WriteLine(string.Join(" ", occurrences));
        }
    }
}
