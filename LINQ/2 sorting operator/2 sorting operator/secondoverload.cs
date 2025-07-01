public class studentt {

    public int roll { get; set; }
    public string name { get; set; }
    public int age { get; set; }
    public int mar { get; set; }
    public String gender { get; set; }

}

public class MarksComparer : IComparer<studentt>  
{

    public int Compare(studentt x, studentt y) {  
    
          return y.mar.CompareTo(x.mar);
    
        }
}

public class MarksCompa : IComparer<studentt> {

    public int Compare(studentt z, studentt y) { 
    
      return z.age.CompareTo(y.age);
    }

}
