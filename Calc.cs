using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalApp
{
    public class Calc
    {
        public void Add(double x, double y)
        {
            Console.WriteLine("Result after addition:\t" +(x+y));
        }
        public void Sub(double x, double y)
        {
            Console.WriteLine("Result after Substraction:\t" + (x - y));
        }
        public void Multi(double x, double y)
        {
            Console.WriteLine("Result after Multiplication:\t" + (x * y));
        }
        public void Div(double x, double y)
        {
            Console.WriteLine("Result after Division:\t" + (x / y));
        }
        public void Avg(double x, double y)
        {
            Console.WriteLine("Average of { x } and {y} =\t: "+(x + y)/2);
        }
    }
}
