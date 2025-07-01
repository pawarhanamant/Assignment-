using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

public static class extensionm {


    public static void add(this int num,string massage ,bool squre) {

        Console.WriteLine($"this is num{num}");

       
        Console.WriteLine($"this is num{massage}");

        //Console.WriteLine($"this is num{squre*squre}");

        if (squre) {
            Console.WriteLine("Square: " + (num * num));

        }

    } 

}