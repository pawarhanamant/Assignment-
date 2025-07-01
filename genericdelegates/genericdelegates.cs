using System;

public delegate T mydelegate<T>(T a,T b);

public class demo
{
    public int intdemo(int x,int y) 
    {
       return x + y;
            
    }
    public void stringdemo(string x,string y) { 
    
       Console.WriteLine(x+y);
    }

  
}

