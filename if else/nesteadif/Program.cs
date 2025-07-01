using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesteadif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 12, num2 = 13;
            if (num > num2)
            {
                Console.WriteLine($"the num is large..{num}");
                if (num < 15) {

                    Console.WriteLine($"the num2 is large ..{num2}");
                }
            }
        }
    }
}
