using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameterconstructor
{
    internal class Program
    {
        class pawar { 

            public string name;
            public string lastname;


        
            public pawar(string NAME,string LASTNAME) { 
            
                name = NAME;
                lastname = LASTNAME;
                method();
            
            }
            public void method() {
                Console.WriteLine($"{name} is the  full name{lastname}");
            
            }
        }
        static void Main(string[] args)
        {
            pawar s1 = new pawar("hpawar","sssss");
        }
    }
}
