using System;
using System.Collections.Generic;
using System.Linq;

namespace DefaultValues
{
    class DefaultValues
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var inputPair = new Dictionary<string, string>();
            var nonNull = new Dictionary<string, string>();
            var @null = new Dictionary<string, string>();

            while (inputLine != "end")
            {
                var tokens = inputLine.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var key = tokens[0];
                var value = tokens[1];
                               
                inputPair[key] = value;
                
                inputLine = Console.ReadLine();
            }

            inputLine = Console.ReadLine();

            foreach (var pair in inputPair)
            {
                if (pair.Value != "null")
                {
                    nonNull.Add(pair.Key, pair.Value);
                }
                else
                {
                    @null.Add(pair.Key, inputLine);
                }
            }

            var result = nonNull
                .OrderByDescending(w => w.Value.Length)
                .ToDictionary(w => w.Key, w => w.Value);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} <-> {item.Value}");
            }
            foreach (var item in @null)
            {
                Console.WriteLine($"{item.Key} <-> {item.Value}");
            }
        }
    }
}