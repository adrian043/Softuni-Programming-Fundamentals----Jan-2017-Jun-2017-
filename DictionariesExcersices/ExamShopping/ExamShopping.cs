using System;
using System.Collections.Generic;

namespace ExamShopping
{
    class ExamShopping
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = new Dictionary<string, long>();
            bool stocking = true;
            bool isOutOfStock = false;

            while (input != "exam time")
            {
                var tokens = input.Split();
                var key = tokens[1];

                if (input == "shopping time")
                {
                    stocking = false;
                }
                else if (tokens[0] == "stock" && stocking == true)
                {
                    var value = long.Parse(tokens[2]);

                    if (!result.ContainsKey(key))
                    {
                        result[key] = value;  
                    }
                    else
                    {
                        result[key] = result[key] + value;
                    }
                }
                else if (tokens[0] == "buy")
                {
                    var value = long.Parse(tokens[2]);

                    if (result.ContainsKey(key))
                    {
                        if (result[key] <= 0)
                        {
                            Console.WriteLine($"{key} out of stock");
                        }
                        result[key] = result[key] - value;
                    }
                    else
                    {
                        Console.WriteLine($"{key} doesn't exist");
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var item in result)
            {
                if (item.Value > 0)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");                    
                }
            }
        }
    }
}