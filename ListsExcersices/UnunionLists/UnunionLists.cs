using System;
using System.Collections.Generic;
using System.Linq;

namespace UnunionLists
{
    class UnunionLists
    {
        static void Main(string[] args)
        {
            var primalList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            var secondaryLists = new List<int>();

            for (int i = 0; i < n; i++)
            {
                secondaryLists = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                AddUniquesAndRemoveMatches(primalList, secondaryLists);       
            }
            primalList.Sort(); 
            Console.WriteLine(string.Join(" ", primalList));
        }  
        private static void AddUniquesAndRemoveMatches(List<int> primalList, List<int> secondaryLists)
        {
            int i = 1;

            foreach (var item in secondaryLists)
            {
                if (!primalList.Contains(item))
                {
                    primalList.Add(item);
                }
                else
                {
                    i++;
                    for (int k = 0; k < i; k++)
                    {
                        primalList.Remove(item);
                    }                    
                }
            }                        
        }
    }
}