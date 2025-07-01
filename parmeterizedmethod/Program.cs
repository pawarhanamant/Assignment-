using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parmeterizedmethod
{
    internal class Program

    {
        class pawar { 
        
            public pawar() {

                Console.WriteLine("no need  return type ");
            
            
            }

            public void methods(string name,string lastname) {

                string NAME = name;
                string LAST= lastname;
                Console.WriteLine($"first name {NAME} and last name {LAST}");
            
            }
        }
        static void Main(string[] args)
        {
            pawar pawar = new pawar();
            pawar.methods("hpawar", "pawar");
        }
    }
}
