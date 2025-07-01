public class MathCalculator<T1, T2, T3>
{
    public T1 Number1;
    public T2 Number2;

    public T3 Add()
    {
        dynamic n1 = Number1;
        dynamic n2 = Number2;

        return n1 + n2;
    }
}
