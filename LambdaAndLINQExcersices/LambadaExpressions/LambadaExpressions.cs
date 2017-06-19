using System;
using System.Collections.Generic;
using System.Linq;

namespace LambadaExpressions
{
    class LambadaExpressions
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var result = new Dictionary<string, KeyValuePair<string, KeyValuePair<string, string>>>();

            while (inputLine != "lambada")
            {
                var tokens = inputLine.Split(new[] { ' ', '=', '>', '.' }, StringSplitOptions.RemoveEmptyEntries);
                var selector = tokens[0];

                if (tokens.Length > 2)
                {
                    string key = tokens[1];
                    var value = new KeyValuePair<string, string>(tokens[2], key);

                    result[selector] = new KeyValuePair<string, KeyValuePair<string, string>>(key, value);
                }

                if (inputLine == "dance")
                {
                    result = result
                        .Select(k =>
                            new KeyValuePair<string, KeyValuePair<string, KeyValuePair<string, string>>>
                            (
                                k.Key,
                                new KeyValuePair<string, KeyValuePair<string, string>>
                                (
                                    k.Value.Key,
                                    new KeyValuePair<string, string>
                                    (
                                        k.Value.Value.Key,
                                        k.Value.Value.Value + $".{k.Value.Key}"
                                    )
                                )
                            )
                        )
                        .ToDictionary(x => x.Key, x => x.Value);
                }

                inputLine = Console.ReadLine();
            }

            result
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Key} => {x.Value.Value.Value}.{x.Value.Value.Key}"));
        }
    }
}