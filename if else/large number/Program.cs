using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace large_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int ch = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int ch2 = int.Parse(Console.ReadLine());
            if (ch > ch2)
            {
                Console.WriteLine($"the first number is big..{ch}");
            }
            else if (ch < ch2)
            {

                Console.WriteLine($"the second  number are large ..{ch2}");



            }
            else {
                Console.WriteLine("the both number are equal");
            }
        }
    }
}
