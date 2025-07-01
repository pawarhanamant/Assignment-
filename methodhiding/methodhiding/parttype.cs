using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodhiding
{
    class parttype :empoloye
    {

        public string salray;
        public  new void print()
        {

            Console.WriteLine($"full info {name}---{emp_id}---{deparment}=== parttiming");
        }

    }
}
