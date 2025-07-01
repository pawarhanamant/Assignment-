
Console.WriteLine("enter the first number ");

int num = int.Parse(Console.ReadLine());
Console.WriteLine("enter the first number ");
int num2 = int.Parse(Console.ReadLine());

try
{

    int result = num / num2;
    Console.WriteLine($"result is {result}");


}
catch (Exception ex)
{
    Console.WriteLine($"exception is {ex.Message}");
}

finally {

    Console.WriteLine("finally blaoc always run ");
}





Console.Read();