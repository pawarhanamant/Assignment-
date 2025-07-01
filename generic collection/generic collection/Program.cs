
using System.Collections.Generic;

List<int> student = new List<int>();

student.Add(10);
student.Add(20);
student.Add(30); 
student.Add(40);



Console.WriteLine("*******all string valuse************");
foreach (int  s in student)
{ 
 Console.WriteLine($"  {s}\t " ); 
}
Console.WriteLine();


student.AddRange(new List<int>() { 50, 60, 70 });
Console.WriteLine("*******all string valuse************");
foreach (int s in student)
{
    Console.WriteLine($"  {s}\t ");
}
Console.WriteLine();





Console.Read();