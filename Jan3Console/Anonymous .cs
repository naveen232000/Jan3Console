using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan3Console
{
    public class Anonymous
    {
        public delegate void CalculateArea(double r);
        static void Main(string[] args)
        {
            CalculateArea ca= new CalculateArea(delegate(double x)
            {
                Console.WriteLine("Area :"+(3.14*x*x));
            });
            //ca.Invoke(1);
            ca(1);
            Console.ReadLine();
        }
    }
}
