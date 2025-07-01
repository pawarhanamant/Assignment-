using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entr array size");
            int size=int.Parse(Console.ReadLine());

            int[] num = new int[size];

            Console.WriteLine("enter the element");
            for (int i = 0; i<size; i++)
            {
                Console.WriteLine(num[i]);
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("enter the array here");
            foreach (int number in num) {
                Console.WriteLine(number);
            }
        }
    }
}
