

printam sc = new printam();
sc.printA();

printdelegets sx =new printdelegets(sc.printA);

sc.printB(sx);

anonymous pd1 = delegate ()
{

    Console.WriteLine("this is anonymouse method");
};

Console.Read(); 