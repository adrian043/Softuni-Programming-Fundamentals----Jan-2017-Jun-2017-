using System;
using System.Collections.Generic;
using System.Linq;

namespace RabbitHole
{
    class RabbitHole
    {
        static void Main()
        {
            var fields = Console.ReadLine().Split().ToList();
            int energy = int.Parse(Console.ReadLine());
            int index = 0;
            bool isEnergyNegative = false;
            bool isExplosed = false;

            while (energy > 0)
            {
                var currentField = fields[index];
                if (currentField == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    break;
                }
                else
                {
                    var actionData = currentField.Split('|');
                    var action = actionData[0];
                    var value = int.Parse(actionData[1]);

                    if (action == "Bomb")
                    {
                        fields.Remove(currentField);
                        energy -= value;
                        index = 0;
                        if (energy <= 0)
                        {
                            isExplosed = true;
                            break;
                        }
                    }
                    else if (action == "Left")
                    {
                        index = (Math.Abs(index + value)) % fields.Count;
                        energy -= value;
                        if (energy <= 0)
                        {
                            isEnergyNegative = true;
                            break;
                        }
                    }
                    else if (action == "Right")
                    {
                        index = (index + value) % fields.Count;
                        energy -= value;
                        if (energy <= 0)
                        {
                            isEnergyNegative = true;
                            break;
                        }
                    }
                }
            }
            if (isEnergyNegative)
            {
                Console.WriteLine("You are tired. You can't continue the mission.");
            }
            else if (isExplosed)
            {
                Console.WriteLine("You are dead due to bomb explosion!");
            }        
        }
    }
}