using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class Cards
{
    public static void Main()
    {
        var pattern = "(?<![0-9])(?:([2-9]|10)|(A|K|Q|J))+(S|H|D|C)";
        var regex = new Regex(pattern);

        var cardsInput = Console.ReadLine();

        var matches = regex.Matches(cardsInput);

        var cards = new List<string>();

        foreach (Match match in matches)
        {
            cards.Add(match.Value);
        }

        Console.WriteLine(string.Join(", ", cards));
    }
}

