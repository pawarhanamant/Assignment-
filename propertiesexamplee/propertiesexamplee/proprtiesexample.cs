using System;

public class Student
{
    private int _marks;

    public int Marks
    {
        get
        {
            if (_marks == 0)
                throw new Exception("Marks not assigned yet!"); // ❌ Error if marks = 0
            return _marks;
        }
        set
        {
            if (value >= 0 && value <= 100)
                _marks = value;
            else
                Console.WriteLine("Invalid marks. Must be between 0 and 100.");
        }
    }
}

