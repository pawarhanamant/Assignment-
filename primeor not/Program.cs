using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeor_not
{
    internal class Program
    {
        static void Main(string[] args)

        {

            char repeat = 'y';
            do
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                int count = 0;

                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                    }
                }

                if (count == 2)
                {
                    Console.WriteLine(num + " is a Prime Number.");
                }
                else
                {
                    Console.WriteLine(num + " is NOT a Prime Number.");
                }
                Console.WriteLine("do you want run again");
                repeat = Convert.ToChar(Console.ReadLine());
            } while (repeat=='y');

        }
    }

}
   
