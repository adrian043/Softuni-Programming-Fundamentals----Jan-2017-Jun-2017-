using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            string[] file1 = File.ReadAllLines("FileOne.txt");
            string[] file2 = File.ReadAllLines("FileTwo.txt");

            //string[] allElements = new string[file1.Length + file2.Length];

            //for (int i = 0; i < file1.Length; i++)
            //{
            //    allElements[i] = file1[i];
            //}

            //int j = 0;

            //for (int i = allElements.Length / 2; i < allElements.Length; i++)
            //{
            //    allElements[i] = file2[j];
            //    j++;
            //}

            //Array.Sort(allElements);

            //foreach (var element in allElements)
            //{
            //    Console.WriteLine(element);
            //}

            var elements = new List<string>();

            foreach (var item in file1)
            {
                elements.Add(item);
            }
            foreach (var item in file2)
            {
                elements.Add(item);
            }

            elements.Sort();
            
            File.WriteAllLines("FileThree.txt", elements);

            foreach (var item in elements)
            {
                Console.WriteLine(item);
            }
        }
    }
}