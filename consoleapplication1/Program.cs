using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double m1 = 56.7;
            double m2 = 65.7;
            double m3 = 75.7;
            double average = m1 + m2 + m3 / 3;
            Console.WriteLine("average of " + m1+","+m2+"and"+m3+"is "+average); 
       }
    }
}
