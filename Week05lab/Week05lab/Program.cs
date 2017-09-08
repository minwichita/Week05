using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Line 1");

            goto line4;
            line4:
            Console.WriteLine("Line 4");
            Console.WriteLine("Line 5");
            
            goto line2;
            line2:
            Console.WriteLine("Line 2");

            goto line9;
            line9:
            Console.WriteLine("Line 9");

        }
    }
}
