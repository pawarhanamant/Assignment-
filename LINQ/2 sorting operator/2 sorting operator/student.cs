public class student : IComparable<student>
{

    public int roll { get; set; }
    public string name { get; set; }
    public int age { get; set; }
    public int mar { get; set; }

    

    public int CompareTo(student s)
    {

        return this.age.CompareTo(s.age);




    }


}