public delegate void printdelegets();

public class printam {

    public void printA() {

        Console.WriteLine("printA method called");



    
    }

    public void printB(printdelegets printA) {

        printA();
    
    
    }

}
