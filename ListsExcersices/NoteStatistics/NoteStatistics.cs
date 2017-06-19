using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteStatistics
{
    class NoteStatistics
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(double.Parse).ToList();
            var notes = "C C# D D# E F F# G G# A A# B".Split().ToList();
            var freqValues = "261.63 277.18 293.66 311.13 329.63 349.23 369.99 392.00 415.30 440.00 466.16 493.88".Split().Select(double.Parse).ToList();

            var naturals = new List<string>();
            var sharps = new List<string>();
            var result = new List<string>();

            double naturalsSum = 0;
            double sharpsSum = 0;

            foreach (var freq in input)
            {
                int valueIndex = freqValues.IndexOf(freq);
                string currentNote = notes[valueIndex];
                result.Add(currentNote);
            }

            foreach (var note in result)
            {
                if (note.Contains("#"))
                {
                    sharps.Add(note);
                }
                else
                {
                    naturals.Add(note);
                }
            }

            foreach (var note in sharps)
            {
                int noteIndex = notes.IndexOf(note);
                double frequency = freqValues[noteIndex];
                sharpsSum += frequency;
            }

            foreach (var note in naturals)
            {
                int noteIndex = notes.IndexOf(note);
                double frequency = freqValues[noteIndex];
                naturalsSum += frequency;
            }

            Console.WriteLine("Notes: {0}", string.Join(" ", result));
            Console.WriteLine("Naturals: {0}",string.Join(", ", naturals));
            Console.WriteLine("Sharps: {0}", string.Join(", ", sharps));
            Console.WriteLine("Naturals sum: {0}", naturalsSum);
            Console.WriteLine("Sharps sum: {0}", sharpsSum);
        }
    }
}
