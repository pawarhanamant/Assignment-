

//customer c1 = new customer();
//c1.printA();


using System.Reflection;

Assembly assembly = Assembly.GetExecutingAssembly();

Type customertype = assembly.GetType("customer");
object instance= Activator.CreateInstance(customertype);
MethodInfo printa = customertype.GetMethod("printA");
printa.Invoke(instance,null);


MethodInfo printb = customertype.GetMethod("printB");
printb.Invoke(null,null);
Console.Read();