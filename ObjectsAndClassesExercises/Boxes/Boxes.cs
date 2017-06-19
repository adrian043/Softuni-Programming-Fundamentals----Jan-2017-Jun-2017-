using System;
using System.Collections.Generic;

namespace Boxes
{
    class Box
    {
        public Point UpperLeft { get; set; }

        public Point UpperRight { get; set; }

        public Point BottomLeft { get; set; }

        public Point BottomRight { get; set; }

        public static int CalculatePerimeter(int width, int height)
        {
            return 2 * width + 2 * height;
        }

        public static int CalculateArea(int width, int height)
        {
            return width * height;
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static double CalculateDistance(Point p1, Point p2)
        {
            var distanceX = Math.Pow(p1.X - p2.X, 2);
            var distanceY = Math.Pow(p1.Y - p2.Y, 2);
            var distance = Math.Sqrt(distanceX + distanceY);

            return distance;
        }
    }

    class Boxes
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var boxes = new List<Box>();

            while (inputLine != "end")
            {
                var tokens = inputLine.Split(new[] { ' ', ':', '|' }, StringSplitOptions.RemoveEmptyEntries);
                
                var newBox = new Box
                {
                    UpperLeft = new Point
                    {
                        X = int.Parse(tokens[0]),
                        Y = int.Parse(tokens[1])
                    },

                    UpperRight = new Point
                    {
                        X = int.Parse(tokens[2]),
                        Y = int.Parse(tokens[3])
                    },

                    BottomLeft = new Point
                    {
                        X = int.Parse(tokens[4]),
                        Y = int.Parse(tokens[5])
                    },

                    BottomRight = new Point
                    {
                        X = int.Parse(tokens[6]),
                        Y = int.Parse(tokens[7])
                    }
                    
                };

                boxes.Add(newBox);

                inputLine = Console.ReadLine();
            }

            foreach (var item in boxes)
            {
                var width = Point.CalculateDistance(item.UpperLeft, item.UpperRight);
                var height = Point.CalculateDistance(item.UpperLeft, item.BottomLeft);
                Console.WriteLine($"Box: {width}, {height}");
                Console.WriteLine($"Perimeter: {Box.CalculatePerimeter((int)width, (int)height)}");
                Console.WriteLine($"Area: {Box.CalculateArea((int)width, (int)height)}");
            }
        }
    }
}