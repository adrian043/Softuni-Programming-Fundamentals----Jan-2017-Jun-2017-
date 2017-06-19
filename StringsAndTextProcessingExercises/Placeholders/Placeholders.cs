using System;

public class Placeholders
 {
     public static void Main()
     {
        var inputLine = Console.ReadLine();
        
        while (inputLine != "end")
        {
            var slicedOfTwo = inputLine.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            var sentance = slicedOfTwo[0].Trim();
            var tokens = slicedOfTwo[1].Trim().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < tokens.Length; i++)
            {
                var placeholder = "{" + i + "}";
                sentance = sentance.Replace(placeholder, tokens[i]);
            }
            Console.WriteLine(sentance);
            inputLine = Console.ReadLine();
        }
     }
 }