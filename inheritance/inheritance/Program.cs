using System;

namespace SingleInheritanceExample
{
    
     public class Person
    {
        public void Greet()
        {
            Console.WriteLine("Hello, I am a person.");
        }
    }

    
   public class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I am studying.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Student student1 = new Student();

            
            student1.Greet();

                        student1.Study();
        }
    }
}
