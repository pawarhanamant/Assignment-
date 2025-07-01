
print del = () =>
{

    Console.WriteLine("this is lambda expression");
};
del();

printA del1 = name => string.Format(name);

string lname = del1("pawar");
Console.WriteLine(lname);   

Console.Read();