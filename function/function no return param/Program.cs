using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_no_return_param
{
    internal class Program
    {
        static void pawarsum(int a, int b)
        { 
            int sum=a+b;
            Console.WriteLine(sum);

        }
        static void Main(string[] args)
        {
            pawarsum(5, 10);

        }
    }
}
