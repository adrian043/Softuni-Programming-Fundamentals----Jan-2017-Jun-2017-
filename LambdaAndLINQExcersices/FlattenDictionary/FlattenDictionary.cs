using System;
using System.Collections.Generic;
using System.Linq;

namespace FlattenDictionary
{
    class FlattenDictionary
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var storedData = new Dictionary<string, Dictionary<string, string>>();

            while (inputLine != "end")
            {
                var tokens = inputLine.Split();

                if (tokens.Length > 2)
                {
                    var key = tokens[0];
                    var innerKey = tokens[1];
                    var innerValue = tokens[2];

                    if (!storedData.ContainsKey(key))
                    {
                        storedData[key] = new Dictionary<string, string>();
                    }

                    storedData[key][innerKey] = innerValue;
                }
                else
                {
                    var key = tokens[1];

                    storedData[key] = storedData[key]
                        .ToDictionary(x => x.Key + x.Value, x => "flatened");
                }

                inputLine = Console.ReadLine();
            }

            var orderedByKey = storedData
                .OrderByDescending(x => x.Key.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in orderedByKey)
            {
                Console.WriteLine(item.Key);

                var orderedInnerStoredData =
                    item.Value
                    .Where(x => x.Value != "flatened")
                    .OrderBy(x => x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);

                var flatened =
                    item.Value
                    .Where(x => x.Value == "flatened")
                    .ToDictionary(x => x.Key, x => x.Value);

                int i = 1;
                foreach (var innerKvp in orderedInnerStoredData)
                {
                    Console.WriteLine($"{i}. {innerKvp.Key} - {innerKvp.Value}");
                    i++;
                }

                foreach (var flaten in flatened)
                {
                    Console.WriteLine($"{i}. {flaten.Key}");
                    i++;
                }
            }
        }
    }
}