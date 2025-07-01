public class company {
    public string Name { get; set; }



    Employee[] _employees;



    public company(Employee[] emps)

    {

        _employees = emps;

    }



    public string this[int id]

    {

        get

        {

            foreach (Employee e in _employees)

            {

                if (e.ID== id)

                {

                    return e.Name;

                }

            }

            return "NOT FOUND";

        }

        set

        {

            foreach (Employee e in _employees)

            {

                if (e.ID == id)

                {

                    e.Name = value;

                }

            }

        }

    }



    public void Details()

    {

        Console.WriteLine($"Company Name : {Name}");



        Console.WriteLine("*** ALL EMPLOYEES ***");

        foreach (Employee e in _employees)

        {

            Console.WriteLine($"Id : {e.ID} Name : {e.Name} City : {e.City}");

        }

    }

}






