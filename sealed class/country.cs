public class country
{


}
public class india : country { }

public class india2 : country { }

public sealed class india3
{



}


public class earth //: india3 
{
    



}

class a { 

    public virtual void Foo() { Console.WriteLine("a"); }

}
class b:a {

    public sealed override void Foo() { Console.WriteLine("b"); }

}
class ab : b {

    public override void Foo() { Console.WriteLine("ab"); }


}