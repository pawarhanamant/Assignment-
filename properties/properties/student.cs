class student 
{
    private int _rollnumber;

    public int Rollnumber 
    {

        get { 
        
         return _rollnumber;
        }
        set {

            if (value > 0)
            {

                _rollnumber = value;

            }
            else {
                Console.WriteLine("you enter negitive number");
            
            }
        
        }
    
    
    }

    private string _name;

    public string Name { 
           
        get {

            return !string.IsNullOrEmpty(_name) ? _name : "not null name";
        
        
        }
        set 
        { 
          _name = value;
        
        }
    
    }

    private int passmaerr=40;

    public int PASSMAR {

        get { 
        
          return passmaerr;
        
        }
    }

}

