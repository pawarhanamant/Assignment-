
using System;
#region first
//delegate void massage(String msg);


//public class typemsg {


//    public void print( string msg) { 

//        Console.WriteLine(msg);
//     }

//}
#endregion first

delegate void cal(int a, int b);

public class result {

    public void add(int x, int y) { 
    
       Console.WriteLine(x+y);
    }

    public void sub(int x,int y) { 
    
        Console.WriteLine(x-y); 
    
    }

    public void mul(int x,int y) { Console.WriteLine(x*y); }

}

