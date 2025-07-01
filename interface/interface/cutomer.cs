public interface IA {

    void print() {

        Console.WriteLine("this is print method");
    
    }
    void printA();
    
}
public interface IB
{ 
  void print(); 
    void printb();

}
public class A : IA, IB
{
    public void print() { 

        Console.WriteLine("print method call");
    
    }

    public void printA() { 
        
        
        Console.WriteLine("printA is called in IA");
    
    }
    public void printb()
    {

        Console.WriteLine("printb method called in b");

    }


}
