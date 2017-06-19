using System;
using System.IO;

namespace OddLines
{
    class OddLines
    {
        public static void Main()
        {
            string[] text = File.ReadAllLines("input.txt");
            for (int i = 1; i < text.Length; i += 2)
            {
                File.AppendAllText("output.txt", text[i] + Environment.NewLine);
            }

            var file = File.ReadAllLines("input.txt");

            for (int i = 0; i < file.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"{file[i]}");
                }
            }
        }
    }
}