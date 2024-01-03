using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan3Console
{
    public class GenericDelegates
    {//Func
        public static double FuncSum(int num1,float num2)
        {
            return num1 + num2;
        }
    //Action
        public static void ActionSum(int num1, double num2)
        {
            double sum=num1 + num2;
            Console.WriteLine("ActionSum : " + sum);
        }
        //Predict
        public static bool PredictResult(string txt)
        {
            if (txt.Length <= 5) { return false; }
            return true;
        }
        static void Main(string[] args)
        {
            Func<int, float, double> fsum = new Func<int, float, double>(FuncSum);
            double sum = fsum (3,4.5f);
            //fsum.Invoke(1, 1.5f);
            Console.WriteLine("Func Sum : " + sum);

            Action<int, double> Asum = new Action<int, double>(ActionSum);
            Asum.Invoke(3, 3.5d);

            Predicate<string> Ps = new Predicate<string>(PredictResult);
            bool res= Ps.Invoke("Naveen");
            Console.WriteLine("Predict Result : "+res);
            Console.ReadLine();
        }
    }
}
