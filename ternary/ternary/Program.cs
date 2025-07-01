using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            string result = (number % 2 == 0) ? "even number " : "odd number";
            Console.WriteLine(result);
        }
    }
}
