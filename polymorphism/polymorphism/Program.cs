using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            eplooye eplooye = new eplooye() { 
            
             name="pawar",
             deparment="marathi",
             id="12"
            
            };
            eplooye.print();

            eplooye e = new parttime()
            {

                name = "pawar",
                deparment = "marathi",
                id = "12",
                salary="1222"

            };
            e.print();
            eplooye ep = new fulltime()
            {

                name = "pawar",
                deparment = "marathi",
                id = "12",
                hours="122"

            };
            ep.print();

            eplooye c = new contractor()
            {
                name = "hhhhhh",
                deparment = "contractor",
                id = "12",
                percentage = "902205"

            };
            c.print();


        }
    }
}
