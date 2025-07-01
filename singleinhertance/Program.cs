using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleinhertance
{
    internal class Program
    {
        public class pawar
        {

            public void me()
            {
                Console.WriteLine("this is me ");
            }
        }

        public class pawar2 : pawar
        {
            public void son()
            {
                Console.WriteLine("and this my son ");
            }
            static void Main(string[] args)
            {
                pawar2 pawar = new pawar2();
                pawar.me();
                pawar.son();
            }
        }
    }
}
