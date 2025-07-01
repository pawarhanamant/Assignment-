using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodhiding
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            
            empoloye fl = new fulltype()
            {
                name = "pawar2",
                deparment = "marathi",
                emp_id="122"

            };
            fl.print();

            parttype parttype = new parttype()
            {
                name = "pawar2",
                deparment = "marathi",
                emp_id = "122"
            };
            parttype.print();


            }
    }
}
