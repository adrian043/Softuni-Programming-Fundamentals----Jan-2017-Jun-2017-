using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_TearListInHalf
{
    class Program
    {
        static void Main(string[] args)
        {
            var freqValues = "261.63 277.18 293.66 311.13 329.63 349.23 369.99 392.00 415.30 440.00 466.16 493.88".Split().Select(double.Parse).ToList();
            var freqNames = "C C# D D# E F F# G G# A A# B".Split().ToList();

            Console.WriteLine(freqValues.IndexOf(261.63));
        }
    }
}