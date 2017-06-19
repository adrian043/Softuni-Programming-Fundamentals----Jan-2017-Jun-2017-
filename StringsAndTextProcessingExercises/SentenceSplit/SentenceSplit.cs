using System;

public class SentenceSplit
{
    public static void Main()
    {
        var input = Console.ReadLine();
        var delimiter = Console.ReadLine();
        //var splitedInput = input.Split(new[] { delimiter }, StringSplitOptions.RemoveEmptyEntries);
        var splitedInput = input.Replace(delimiter, ", ");        
        Console.WriteLine("[" + string.Join(", ", splitedInput) + "]");
    }
}