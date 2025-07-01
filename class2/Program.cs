using System;

namespace class2
{
    internal class Program
    {
        class Pawar
        {
            public int num;
            public int num2;

         
            public void ReadNumbers()
            {
                Console.WriteLine("Enter first number:");
                num = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number:");
                num2 = int.Parse(Console.ReadLine());
 
            public void Add()
            {
                int result = num + num2;
                Console.WriteLine($"Addition = {result}");
            }

            public void Sub()
            {
                int result = num - num2;
                Console.WriteLine($"Subtraction = {result}");
            }
        }

        static void Main(string[] args)
        {
            Pawar pawar = new Pawar();   
            pawar.ReadNumbers();          
            pawar.Add();                
            pawar.Sub();                  
        }
    }
}
