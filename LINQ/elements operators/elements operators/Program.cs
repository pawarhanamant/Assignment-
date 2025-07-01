


List<int> numbers = new List<int> { 10, 20, 30, 40, 50, 60, };
#region Element
//int element = numbers.ElementAt(5);
//Console.WriteLine(element);


//int element = numbers.ElementAtOrDefault(20);
//   Console.WriteLine($" ElementAtOrDefault :{element}");

#endregion  Element


#region first
//int result= numbers.First();
//int result = numbers.First(n => n > 40);

//Console.WriteLine(result);


//int result = numbers.FirstOrDefault(n => n > 100);
//Console.WriteLine(result);




#endregion first


#region last

int result = numbers.Last(n => n < 40);
Console.WriteLine(result);

int resultt = numbers.LastOrDefault(n => n > 100);
Console.WriteLine(result);
#endregion last

#region single

//int result = numbers.Single(n=>n<20);
//int result = numbers.Single();

int resul = numbers.SingleOrDefault();
Console.WriteLine(result);
    

#endregion  single

Console.Read();