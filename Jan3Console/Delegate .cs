using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan3Console
{
    public class Delegate
    {
        public delegate double Deli(double a, double b);
        public static double sum(double num1,double num2) { 
            return (num1 + num2); 
        }
        public static double Diff(double num1, double num2)
        {
            return (num1 - num2);
        }
        static void Main(string[] args)
        {
            Deli deli;
            deli = sum;
            double ans = deli.Invoke(2.22, 3.45);
            Console.WriteLine("Delegate Sum = "+ans);
            deli = Diff;
            double sub = deli.Invoke(2.22, 3.45);
            Console.WriteLine("Delegate Diff = " + sub);
            Console.ReadLine();

        }
    }
}
