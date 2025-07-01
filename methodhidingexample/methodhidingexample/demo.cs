public class First {

    public void methoddemo() {

        Console.WriteLine("firstmethod run");
    }


}

public class Second :First{

    public  new void   methoddemo()
    {

        Console.WriteLine("second class method run");
    }

}

public class Third:First {

    public  new void methoddemo()
    {

        Console.WriteLine("third class method run");
    }

}