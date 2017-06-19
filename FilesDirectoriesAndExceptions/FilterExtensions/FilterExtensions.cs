using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace FilterExtensions
{
    class FilterExtensions
    {
        public static void Main()
        {
            var fileExtention = Console.ReadLine();
            var files = Directory.GetFiles("input");

            foreach (var file in files)
            {
                var splited = file.Split(new[] { '\\', '.'}, StringSplitOptions.RemoveEmptyEntries);

                if (fileExtention == splited[splited.Length - 1])
                {
                    Console.WriteLine(string.Join("", file.Skip(6)));
                }
            }
        }
    }
}