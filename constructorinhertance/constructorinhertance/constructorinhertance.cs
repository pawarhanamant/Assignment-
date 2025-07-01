
public class Baseclass {

    //public Baseclass() { }

    public void demo()
    {

        Console.WriteLine("demo call in base");
    }
    public Baseclass(string name) {

        Console.WriteLine($"this base class construtor{name}");
    }

}

public class Derivedclass1:Baseclass {


    public void demo2()
    {

        Console.WriteLine("demo call in derived class 1");
    }

    public Derivedclass1():base("hanamant") 
    { 
        
        Console.WriteLine("this is drivedc class 1 constructor"); 
    }
}

public class Drivedclass2 : Baseclass {

    public void demo3()
    {

        Console.WriteLine("demo call in derived class 2");
    }

    public Drivedclass2():base("hana")
    {
        Console.WriteLine("this is drived class 2 construtor");

    }
}