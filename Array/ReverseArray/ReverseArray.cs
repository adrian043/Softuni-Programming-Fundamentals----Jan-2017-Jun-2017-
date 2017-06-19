using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int j = arr.Length - 1; j >= 0; j--)
            {
                Console.Write(arr[j]);
                if (j > 0)
                {
                    Console.Write(' ');
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
