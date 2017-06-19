using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Test
{
    public static void Main()
    {
        var text = "astalavista baby";
        var pattern = "aaa";

        foreach (var lett in pattern)
        {
            text = text.Replace(lett.ToString(), "");
        }     

        Console.WriteLine(text);
    }
}