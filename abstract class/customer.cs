public abstract class customer
{
    public void showtiming() {

        Console.WriteLine("all shows");

    
    }
    public abstract void printticit();
   

}

public class Silvercustomer : customer {

    public override void printticit()
    {
        Console.WriteLine("silver ticit printer");
    }


}
public class goldcustomer : customer {

    public override void printticit()
    {
        Console.WriteLine("golden ticit printer");
    }
}