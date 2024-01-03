using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan3Console
{
    public class Indexer
    {
        private string[] Cities = new string[10];
        public string this [int i]
        {
            get { return Cities[i]; }
            set { Cities[i] = value;}
        }
    }
    public class Cities
    {
        static void Main(string[] args)
        {
            Indexer city= new Indexer();
            city[0] = "Chennai";
            city[1] = "Delhi";
            city[2] = "Mumbai";
            for (int i = 0;i<10;i++) {
                Console.WriteLine("Index {0} => {1}",i,city[i]);
            }
            Console.ReadLine();
        }
    }
}
