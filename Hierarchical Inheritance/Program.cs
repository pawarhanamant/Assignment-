using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical_Inheritance
{
    internal class Program
    {
        public class info {

            public void infoo() {
                Console.WriteLine("this  car are four wheel");
                Console.WriteLine("this run road ");
                Console.WriteLine("this car need driver");
            }
        }
        public class bmw : info
        {
            public void bmww()
            {
                Console.WriteLine("bmw develpo the pawar");
            }
        }
        public class mar : info
        {
            public void marw()
            {
                Console.WriteLine("mar devloper raut");
            }
        }
        public class thar : info
        {
            public void tharr()
            {
                Console.WriteLine("devloper is mahindra companmy");

            }
        }
        static void Main(string[] args)
        {
            thar thar = new thar();
            thar.tharr();
            thar.infoo();


            bmw w = new bmw();
            w.bmww();
            w.infoo();
        }
    }
}
