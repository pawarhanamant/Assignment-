
interface bmw {

    public void start();

}

interface swift { 

    public void start();

}

public class car:bmw,swift {


     void bmw.start() {


        Console.WriteLine("this car bmw start");
    
    }

     void swift.start()
    {
        Console.WriteLine("this is swift");
    }
}