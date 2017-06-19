using System;
using System.Linq;
using System.Collections.Generic;

namespace ClosestTwoPoints
{
    class Point
    {
        public double X { get; set; } 

        public double Y { get; set; }

        public string Print()
        {
            return $"({X}, {Y})";
        }
    }

    class ClosestTwoPoints
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split();

                var currentPoint = new Point
                {
                    X = double.Parse(inputLine[0]),
                    Y = double.Parse(inputLine[1])
                };

                points.Add(currentPoint);
            }

            var minDistance = double.MaxValue;
            Point firstPointResult = null;
            Point secondPointResult = null;

            for (int first = 0; first < points.Count; first++)
            {
                for (int second = first + 1; second < points.Count; second++)
                {
                    var firstPoint = points[first];
                    var secondPoint = points[second];

                    var distance = CalcDistance(firstPoint, secondPoint);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        firstPointResult = firstPoint;
                        secondPointResult = secondPoint;
                    }
                }
            }

            Console.WriteLine($"{minDistance:f3}");
            Console.WriteLine(firstPointResult.Print());
            Console.WriteLine(secondPointResult.Print());
        }
        static double CalcDistance(Point p1, Point p2)
        {
            var distanceX = Math.Pow(p1.X - p2.X, 2);
            var distanceY = Math.Pow(p1.Y - p2.Y, 2);
            var distance = Math.Sqrt(distanceX + distanceY);

            return distance;
        }
    }
}