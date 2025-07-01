using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading
{
    public class methodvorloading
    {
        public void printme() {

            Console.WriteLine("this is first method ");



        }
        public void printme(int num) {
            Console.WriteLine(num);


        }
        public void printme(ref int num) { 
            Console.WriteLine($"using ref{num}");
        
        }
        public void printme(float num) {
            Console.WriteLine(num);
        
        }
        public void printme(ref float num) { 
            Console.WriteLine(num);
        
        }
        public void printme(string str) {

            Console.WriteLine(str);
        
        }
        public void printme(ref string str) { 
            Console.WriteLine($" using ref{str}");
        
        }
        public void printme(int num,string str) {

            Console.WriteLine($"int is {num} and string {str}");
        }
        public void printme(string str,int num) { 
        
            Console.WriteLine($"sting is {str} and int {num}");
        }


    }
 }

