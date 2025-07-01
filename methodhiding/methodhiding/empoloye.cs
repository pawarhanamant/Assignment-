using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodhiding
{
    internal class empoloye
    {
        public string name;
        public string emp_id;
        public string deparment;


        public void print() {

            Console.WriteLine($"full info {name}---{emp_id}---{deparment}");
        }
    }
}
