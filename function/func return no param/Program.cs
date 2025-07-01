using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace func_return_no_param
{
    internal class Program
    {
        static string mess()
        {
            return "welcome";
        }
        static void Main(string[] args)
        {
            string message=mess();
            Console.WriteLine(message);
        }
    }
}
