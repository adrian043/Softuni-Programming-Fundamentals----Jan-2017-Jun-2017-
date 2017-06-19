using System;
using System.Collections.Generic;

public class SerializeString
{
    public static void Main()
    {
        var input = Console.ReadLine();
        var charPositionPair = new Dictionary<string, List<string>>();

        for (int i = 0; i < input.Length; i++)
        {
            if (!charPositionPair.ContainsKey(input[i].ToString()))
            {
                charPositionPair[input[i].ToString()] = new List<string>();
            }

            charPositionPair[input[i].ToString()].Add(i.ToString());
        }

        foreach (var lett in charPositionPair)
        {
            Console.WriteLine("{0}:{1}", lett.Key.ToString(), string.Join("/", lett.Value));
        }
    }
}