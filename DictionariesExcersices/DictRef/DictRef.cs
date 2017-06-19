using System;
using System.Collections.Generic;

namespace DictRef
{
    class DictRef
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = new Dictionary<string, int>();
            
            while (input != "end")
            {
                var tokens = input.Split();
                var key = tokens[0];
                var val = tokens[2];
                int number = 0;
                bool isNum = int.TryParse(tokens[2], out number);                                
                            
                if (!isNum)
                {
                    if (result.ContainsKey(val))
                    {
                        var refVal = result[val];
                        result[key] = refVal;
                    }                                                                            
                }
                else
                {
                    result[key] = int.Parse(val);
                }
                                
                input = Console.ReadLine();
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} === {item.Value}");
            }
        }
    }
}