using System;

namespace Example
{
    class Example
    {
        static void Main()
        {
            Cat firstCat = new Cat();
            firstCat.Name = "Tom";
            firstCat.Age = 2;
            firstCat.Color = "Black";

            Cat secondCat = new Cat
            {
                Name = "Precious",
                Age = 3,
                Color = "Red"
            };

            Console.WriteLine(firstCat.SayMeow());
        }
    }
}