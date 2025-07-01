using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodhiding
{
    class fulltype :empoloye
    {
        public string salary;


        public new void print()
        {

            Console.WriteLine($"full info {name}---{emp_id}---{deparment}====fulltiming");
        }




    }
}
