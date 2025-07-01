using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticconstructor
{
    internal class Program

    {
        public class pawar {

            public string beheviros;
            static string name;

            static pawar(){
                name = "pawar";
                Console.WriteLine("this is static constructor");
                Console.WriteLine($"{name}");

              }

            public void normalmethod() {

                beheviros = "goood";
                Console.WriteLine(beheviros);
            
            
            }
        
        }


        static void Main(string[] args)
        { 

            pawar pawar = new pawar();
            pawar.normalmethod();
            pawar.normalmethod();
            pawar.normalmethod();
        }
    }
}
