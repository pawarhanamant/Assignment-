using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method3
{
    internal class Program
    {
        static int pawar(int num)
        {
            return num * num;
        }
        static void Main(string[] args)
        {
           int result=pawar(5);
            Console.WriteLine(result);
        }
    }
}
