using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace thisprogram
{
    internal class Program
    {
        public class pawar {

            public string name;
            public string lastname;

            public void methods( string name,string lastname) {

               this.name = name;
                this.lastname = lastname;

               
                  
               
            }
            public void method2() {

                Console.WriteLine($"fist name is {name}and last name {lastname}");
            }



        }
        static void Main(string[] args)
        {
            pawar pawar = new pawar();
            pawar.methods("hpawar","lpawar");
            pawar.method2();
        }
    }
}
