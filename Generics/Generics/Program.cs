add c1 = new add();
bool isequal = c1.AreEqual(10, 10);
Console.WriteLine($"Is 10 & 10 are equal? : {isequal}");

isequal = c1.AreEqual("vishal", "mahesh");
Console.WriteLine($"Is vishal & mahesh are equal? : {isequal}");
isequal = c1.AreEqual("vishal", "vishal");
Console.WriteLine($"Is vishal & mahesh are equal? : {isequal}");

MathCalculator<int,int ,int> c2=new MathCalculator<int, int, int>();

c2.Number1 = 10;
c2.Number2 = 10;


int add = c2.Add();
Console.WriteLine($"Result = {add}");






Console.Read();