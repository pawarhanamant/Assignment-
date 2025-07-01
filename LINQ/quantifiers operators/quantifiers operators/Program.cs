List<int> numbers = new List<int> { 10, 20, 30 };

bool hasEven = numbers.Any(n => n % 2 == 0);
Console.WriteLine("Any even number: " + hasEven); 


bool allmethod=numbers.All(n => n> 5);
Console.WriteLine(allmethod);

bool conatindemo =  numbers.Contains(10);
Console.WriteLine(conatindemo);



Console.Read();

