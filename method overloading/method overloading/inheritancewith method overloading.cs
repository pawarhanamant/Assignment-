using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading
{
    public class inheritancewith_method_overloading
    {

        public void show() {

            Console.WriteLine("this basic method ");
        
        
        }

        public void show(int num)

        {
            Console.WriteLine($"this is second method with same name int type{num}");
            }

        public class AAAAAA : inheritancewith_method_overloading {


            public void show(string name) {

                Console.WriteLine($"this is string{name}");
            
            
            
            }
        
        }
    }
}
