using System;

public delegate void mycall(string msg);

public class workr {

    public void dowor(mycall massage) 
    {

        Console.WriteLine(" started ");
        Console.WriteLine("ending");
        massage("succefully complete");
    
    }
    

}

public class Notifier
{
    public void ShowNotification(string msg)
    {
        Console.WriteLine(msg);
    }
}