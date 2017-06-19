using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            decimal ppl = decimal.Parse(Console.ReadLine());
            decimal cap = decimal.Parse(Console.ReadLine());
            
            decimal courses = Math.Ceiling(ppl / cap);
            Console.WriteLine(courses);
        }
    }
}
