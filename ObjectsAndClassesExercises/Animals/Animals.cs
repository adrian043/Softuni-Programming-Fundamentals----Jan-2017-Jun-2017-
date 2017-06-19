using System;
using System.Collections.Generic;

namespace Animals
{
    class Dog
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int NumberOfLegs { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
        }
    }

    class Cat
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int IQ { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }
    }

    class Snake
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int CrueltyCoeff { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }
    }

    class Animals
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var dogs = new Dictionary<string, Dog>();
            var cats = new Dictionary<string, Cat>();
            var snakes = new Dictionary<string, Snake>();

            while (inputLine != "I'm your Huckleberry")
            {
                var tokens = inputLine.Split();

                if (tokens.Length > 3)
                {
                    if (tokens[0] == "Dog")
                    {
                        var newDog = new Dog
                        {
                            Name = tokens[1],
                            Age = int.Parse(tokens[2]),
                            NumberOfLegs = int.Parse(tokens[3])
                        };
                        dogs.Add(tokens[1], newDog);
                    }
                    else if (tokens[0] == "Cat")
                    {
                        var newCat = new Cat
                        {
                            Name = tokens[1],
                            Age = int.Parse(tokens[2]),
                            IQ = int.Parse(tokens[3])
                        };
                        cats.Add(tokens[1], newCat);
                    }
                    else if (tokens[0] == "Snake")
                    {
                        var newSnake = new Snake
                        {
                            Name = tokens[1],
                            Age = int.Parse(tokens[2]),
                            CrueltyCoeff = int.Parse(tokens[3])
                        };
                        snakes.Add(tokens[1], newSnake);
                    }                    
                }

                else
                {                    
                    var name = tokens[1];

                    if (dogs.ContainsKey(name))
                    {
                        dogs[name].ProduceSound();                            
                    }
                    else if (cats.ContainsKey(name))
                    {
                        cats[name].ProduceSound();
                    }
                    else if (snakes.ContainsKey(name))
                    {
                        snakes[name].ProduceSound();
                    }
                }

                inputLine = Console.ReadLine();
            }

            foreach (var dog in dogs.Values)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
            }

            foreach (var cat in cats.Values)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.IQ}");
            }

            foreach (var snake in snakes.Values)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoeff}");
            }
        }
    }
}