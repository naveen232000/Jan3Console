using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan3Console
{
    public class Lambda
    {
        public delegate void CalculateArea(double r);
        static void Main(string[] args)
        {
            CalculateArea ca=x => Console.WriteLine("Area : "+(3.14*x*x));
            ca(1);
            Func<double, double> cp = x => (3.14 * x * x);
            double area=cp(1);
            Console.WriteLine("Func Area : "+area);
            Console.ReadLine();
        }
    }
}
