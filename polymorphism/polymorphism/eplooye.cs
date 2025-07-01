using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class eplooye
    {
        public string name;
        public string id;
        public string deparment;


        public virtual  void print() {

            Console.WriteLine($"name is {name} id is{id} deparment is {deparment}");
        }
    }
}
