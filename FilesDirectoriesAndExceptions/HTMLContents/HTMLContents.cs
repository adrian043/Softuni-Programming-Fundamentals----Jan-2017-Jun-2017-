using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class HTMLContents
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();
        var html = new StringBuilder();

        html.AppendLine("<!DOCTYPE html>");
        html.AppendLine("<html>");
        
        html.AppendLine("<body>");

        while (inputLine != "exit")
        {
            var tokens = inputLine.Split();
            var tag = tokens[0];
            var content = tokens[1];

            if (tag == "title")
            {
                html.AppendLine("<head>");
                html.AppendLine($"\t <{tag}>{content}</{tag}>");
                html.AppendLine("</head>");
            }               

            inputLine = Console.ReadLine();
        }

        html.AppendLine("</body>");
        html.AppendLine("</html>");

        Console.WriteLine(html);
    }
}
