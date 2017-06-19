using System;
using System.Collections.Generic;
using System.Linq;

namespace _01Exercises
{
    class Exercises
    {
        public string Topic { get; set; }

        public string CourseName { get; set; }

        public string JudgeContestLink { get; set; }

        public List<string> Problems { get; set; }
    }

    class _01Exercises
    {
        public static void Main()
        {
            var exercises = new List<Exercises>();
            var inputLine = Console.ReadLine();

            while (inputLine != "go go go")
            {
                var currentExercise = inputLine.Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                
                var newExercise = new Exercises
                {
                    Topic = currentExercise[0],
                    CourseName = currentExercise[1],
                    JudgeContestLink = currentExercise[2],
                    Problems = currentExercise.Skip(3).ToList()
                };

                exercises.Add(newExercise);
                inputLine = Console.ReadLine();
            }

            foreach (var exercise in exercises)
            {
                Console.WriteLine($"Exercises: {exercise.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{exercise.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {exercise.JudgeContestLink}");
                int i = 1;
                foreach (var problem in exercise.Problems)
                {                    
                    Console.WriteLine($"{i}. {problem}");       
                    i++;             
                }
                
            }
        }        
    }
    
}