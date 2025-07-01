using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num=int.Parse(Console.ReadLine());
            for (int i = 0; i <= num; i++) {

                Console.WriteLine(i);
            }
        }
    }
}
