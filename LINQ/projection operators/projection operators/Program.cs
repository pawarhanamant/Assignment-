//List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

//var squares = numbers.Select(n => n * n);

//foreach (var square in squares)
//{
//    Console.WriteLine(square);
//}



List<Student> students = new List<Student>()
{

    new Student{ Name="pawar",subject= new List<string>{"Engalish","marathi","hindi"} },
    new Student{Name="shinde",subject=new List<string>{"maths","bio","Engalish","hinde" } }
};

var result = students.SelectMany(s => s.subject);

foreach (var item in result)
{
    Console.WriteLine(item);
}



Console.Read();