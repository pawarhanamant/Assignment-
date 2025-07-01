using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class parttime:eplooye
    {
        public string salary;

        public override void print()
        {

            Console.WriteLine($"name is {name} id is{id} deparment is {deparment} hours{salary}");
        }
    }

    public class contractor:parttime {

        public string percentage;

        public override void print() {

            Console.WriteLine($"name is {name} id is{id} deparment is {deparment} hours{percentage} ");


        }


    }
}
