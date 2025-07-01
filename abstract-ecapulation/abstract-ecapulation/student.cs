
    internal class student
    {
        private string fname;
        private string id;

        public student(string fname, string id)
        {
           this.fname = fname;
             this.id = id;
        }

        private bool IsValid() { 

            return !string.IsNullOrEmpty(fname)&&
                !string.IsNullOrEmpty(id);

        }

        public void insert() {
            if (IsValid())
            {
                Console.WriteLine("succsefully");

            }
            else {
                Console.WriteLine("not unsuccefully");
            
            
            }
        
        
        
        }
    }

