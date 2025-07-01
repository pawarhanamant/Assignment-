using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class fulltime:eplooye
    {
        public string hours;

        public override void print()
        {

            Console.WriteLine($"name is {name} id is{id} deparment is {deparment} hors{hours}");
        }
    }
}
