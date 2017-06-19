using System;

namespace DistanceBetweenPoints
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    class DistanceBetweenPoints
    {
        public static void Main()
        {
            var inputLine1 = Console.ReadLine().Split();
            var inputLine2 = Console.ReadLine().Split();

            var p1 = new Point
            {
                X = double.Parse(inputLine1[0]),
                Y = double.Parse(inputLine1[1])
            };

            var p2 = new Point
            {
                X = double.Parse(inputLine2[0]),
                Y = double.Parse(inputLine2[1])
            };

            CalcDistance(p1, p2);
        }

        static void CalcDistance(Point p1, Point p2)
        {
            var distanceX = Math.Pow(p1.X - p2.X, 2);
            var distanceY = Math.Pow(p1.Y - p2.Y, 2);
            var distance = Math.Sqrt(distanceX + distanceY);

            Console.WriteLine($"{distance:F3}");
        }
    }
}