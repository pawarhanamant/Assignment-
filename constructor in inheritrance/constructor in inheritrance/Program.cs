using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_in_inheritrance
{
    internal class Program
    {

        public class pawar { 
        
        
          public pawar( string name ) { 
            
                    Console.WriteLine(name);
            }
        }

        public class pawar2 :pawar {

            public pawar2() :base("pawar"){
                Console.WriteLine("this is child class program");
            
            
            
            }
        }

        static void Main(string[] args)
        {
              pawar2 pawar2 = new pawar2(); 

        }
    }
}
