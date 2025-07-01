using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_return_with_para
{
    internal class Program
    {
        static int add(int a, int b) { 
          return a + b;
        }
        static void Main(string[] args)
        {
            int result=add(1, 2);
            Console.WriteLine(result);
        }
    }
}
