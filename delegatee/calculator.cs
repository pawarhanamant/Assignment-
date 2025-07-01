public delegate void operation(int a, int b);

public class calculator
{


    public void add(int x, int y)
    {

        Console.WriteLine(x + y);


    }

    public void sub(int x, int y)
    {

        Console.WriteLine(x - y);
    }
    public void mul(int x, int y)
    {

        Console.WriteLine(x * y);

    }

    public void result(int a, int b, operation op)
    {
        op(a, b);


    }

}