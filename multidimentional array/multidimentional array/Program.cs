using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multidimentional_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [,]number=new int[2,3]
            {
                { 1,2,3},{ 4,5,6}
            };
            Console.WriteLine("multi array");
            for (int i = 0; i < number.GetLength(0); i++) {
                for (int j = 0; j < number.GetLength(1); j++) {
                    Console.WriteLine(number[i, j]+"");
                
                }
                Console.WriteLine();
            }
        }
    }
}
