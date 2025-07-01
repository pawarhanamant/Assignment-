returntype rt = new returntype();
mydel del = rt.printA;
del += rt.printB;
del += rt.printC;

 int result = del();
Console.WriteLine(result);





Console.Read();