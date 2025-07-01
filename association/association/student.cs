using System;

class Address
{
    public string City;

    public Address(string city)
    {
        City = city;
    }
}

class Person
{
    public string Name;
    public Address Addr;  // Association: Person has an Address

    public Person(string name, Address address)
    {
        Name = name;
        Addr = address;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"City: {Addr.City}");
    }
}

