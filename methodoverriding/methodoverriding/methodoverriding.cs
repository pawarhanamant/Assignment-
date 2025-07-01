
public class car {

    public virtual void  start() {

        Console.WriteLine("car is started");
    
    }

}

public class Swift:car{

    public override void start()
    {

        Console.WriteLine(" swift car is started");

    }

}

public class bmw :car{

    public override void start()
    {

        Console.WriteLine(" bmw car is started");

    }


}