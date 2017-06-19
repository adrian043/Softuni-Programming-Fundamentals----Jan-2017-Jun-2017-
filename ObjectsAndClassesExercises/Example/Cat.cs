using System;

namespace Example
{
    class Cat
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Color { get; set; }

        public string SayMeow()
        {
            return $"Meowy, I am {Name}. I am {Color} and I am {Age} years old. MEOW!";
        }
    }
}