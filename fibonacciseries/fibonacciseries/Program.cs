using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacciseries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int teram,a=0,b=1,c;
            Console.WriteLine("enter the number");
            teram=int.Parse(Console.ReadLine());

            for (int i = 0; i <= teram; i++)
            {

                Console.WriteLine(a+"");
                c = a + b;
                a = b;
                b = c;

            }
        }
    }
}
