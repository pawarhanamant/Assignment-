using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number number");
            double num1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the second number");
            double num2=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("entr the operator");
            char cal=Convert.ToChar(Console.ReadLine());

            switch (cal)
            {
                case '+':
                    Console.WriteLine($"result..{num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"result...{num1 - num2}");
                    break;
                default:
                    Console.WriteLine("invaild operator");
                    break;

            }

            
            
            
        }
    }
}
