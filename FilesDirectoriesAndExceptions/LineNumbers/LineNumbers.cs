using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace LineNumbers
{
    class LineNumbers
    {
        public static void Main()
        {
            var file = File.ReadAllLines("input.txt");

            for (int i = 0; i < file.Length; i++)
            {
                Console.WriteLine($"{i+1}. {file[i]}");
            }
        }
    }
}