using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Stateless
{
    public static void Main()
    {
        var collapse = Console.ReadLine();

        while (collapse != "collapse")
        {
            var fiction = Console.ReadLine();

            foreach (var lett in fiction)
            {
                collapse = collapse.Replace(lett.ToString(), "");
            }
            Console.WriteLine(collapse);
            collapse = Console.ReadLine();
        }        
    }
}