using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticmethod
{
    internal class Program
    {
        public class pawar {

            public static void methods(int num,int num2) {

                int resut = num * num2;
                Console.WriteLine($"{resut}");
            
            }
        }
        static void Main(string[] args)
        {
            pawar.methods(12,23);
        }
    }
}
