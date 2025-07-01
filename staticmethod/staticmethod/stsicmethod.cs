public class ststicmethod
{
    public int n { get; set; }
    public static string name = "pawar";
    public static void printA()
    {


        Console.WriteLine("printa static metyhod call");

    }

    public static void printB()

    {
        Console.WriteLine(name);
        //Console.WriteLine(n);


    }
}