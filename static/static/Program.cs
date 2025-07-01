using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace @static
{
    internal class Program
    {
        public class pawar {

            public static void methods() {

                Console.WriteLine("this is static method ");
                
            
            
            }
            public void method() { 
            
               Console.WriteLine("this is normal method");
            }

            
        }
        static void Main(string[] args)
        {
            pawar pawar = new pawar();
            pawar.method();
            pawar.methods();
            
        }
    }
}
