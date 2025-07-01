using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilevelinhertnace
{
    internal class Program
    {
        public class grandfather {

            public void tell() {
                Console.WriteLine("i am grandfather of ");
            
            }
           
        }
        public class father:grandfather {

            public void tell2() {

                Console.WriteLine("i am father ");

            }
        }
        public class son :father
        {

            public void tell3()
            {
                Console.WriteLine("i am son ");
            }
        }
        public class son2:son {

            public void tell4()
            {
                Console.WriteLine("i am second son ");
            }
        
        }
        
        static void Main(string[] args)
        {
            son2 son = new son2();
            son.tell3();
            son.tell2();
            son.tell();
            son.tell4();

        }
    }
}
