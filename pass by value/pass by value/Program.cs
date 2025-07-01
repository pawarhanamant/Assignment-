using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pass_by_value
{
    internal class Program
    {
       
            
            static void ModifyValue(int num)
            {
                num = 100;  
                Console.WriteLine("Inside Method: num = " + num);
            }

            static void Main()
            {
                int x = 50;
                Console.WriteLine("Before Method Call: x = " + x);

                   ModifyValue(x);

                Console.WriteLine("After Method Call: x = " + x);  
            }
        }

    }

