
using System.Collections;

ArrayList number = new ArrayList();

number.Add(10);
number.Add(20);
number.Add(30);
number.Add(40);
number.Add(50);

Console.WriteLine($"number in array    {number.Count}  ");


Console.WriteLine("**** Items in ArrayList *****");

foreach (int i in number)

{

    Console.Write($"{i} ");

}

Console.WriteLine(); // new line
Console.WriteLine();

ArrayList temp = new ArrayList() { 90,90};   
number.AddRange(temp);
Console.WriteLine("**** Items in ArrayList *****");

foreach (int i in number)

{

    Console.Write($"{i} ");

}

Console.WriteLine(); // new line
Console.WriteLine();

number.Insert(4, 70);
Console.WriteLine("**** Items in ArrayList *****");

foreach (int i in number)

{

    Console.Write($"{i} ");

}

Console.WriteLine(); // new line
Console.WriteLine();

ICollection temp1=new ArrayList() {1,2,3};
number.InsertRange(0, temp1);
Console.WriteLine("**** Items in ArrayList *****");

foreach (int i in number)

{

    Console.Write($"{i} ");

}

Console.WriteLine(); // new line
Console.WriteLine();

number.RemoveAt(9);
Console.WriteLine("**** Items in ArrayList *****");

foreach (int i in number)

{

    Console.Write($"{i} ");

}

Console.WriteLine(); // new line
Console.WriteLine();

number.Remove(90);
Console.WriteLine("**** Items in ArrayList *****");

foreach (int i in number)

{

    Console.Write($"{i} ");

}

Console.WriteLine(); // new line
Console.WriteLine();


number.RemoveRange(0,3);
Console.WriteLine("**** Items in ArrayList *****");

foreach (int i in number)

{

    Console.Write($"{i} ");

}

Console.WriteLine(); // new line
Console.WriteLine();

Console.Read();