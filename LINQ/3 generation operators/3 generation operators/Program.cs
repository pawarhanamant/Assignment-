IEnumerable<string> emptyList = Enumerable.Empty<string>();

Console.WriteLine("Count: " + emptyList.Count());




Console.WriteLine("*********this is defaultempty method******* ");

List<string> names = new List<string>(); 

var result = names.DefaultIfEmpty("No Name");

foreach (var name in result)
{
    Console.WriteLine(name);
}



//var numbers = Enumerable.Range(1, 5);


IEnumerable<int> numbers = Enumerable.Range(1, 5);



foreach (var num in numbers)
{
    Console.WriteLine(num);
}

IEnumerable<string> msg = Enumerable.Repeat<string>("hell0",9);
foreach (var item in msg)
{
    Console.WriteLine(item);
}



Console.Read();