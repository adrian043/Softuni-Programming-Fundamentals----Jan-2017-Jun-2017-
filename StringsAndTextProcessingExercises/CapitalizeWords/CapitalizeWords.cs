using System;
using System.Collections.Generic;
using System.Linq;

public class CapitalizeWords
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();
        var words = new List<string>();

        while (inputLine != "end")
        {
            var tokens = inputLine
                    .Split(new char[] { ',', ' ', '=', '-', '>', ':', '~', '}', '|', '{', '`', '^', ']', '\\', '[', '?', '<', ';', '/', '.', '+', '*', ')', '(', '&', '%', '$', '#', '\"', '!' }
                    , StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in tokens)
            {
                var inRightCase = word.First().ToString().ToUpper() + string.Join("", word.Skip(1)).ToLower();
                words.Add(inRightCase);
            }

            Console.WriteLine(string.Join(", ", words));

            words.Clear();

            inputLine = Console.ReadLine();
        }
    }
}