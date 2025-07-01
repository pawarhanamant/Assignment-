using System;

public delegate void printmsg();

  public  class pritndelegate {


    public  void  printdel(printmsg massage ) {

        massage();
    
    }

}

public class msg {

    public void first() {


        Console.WriteLine("hello");
    }

    public void second() { Console.WriteLine("namaste"); }


    public void third()
    {
        Console.WriteLine("hii");
    }

}