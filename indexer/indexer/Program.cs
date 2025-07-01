Employee[] employees = new Employee[] {

   new Employee(){ ID=1,Name="pawar",City="pune"},
    new Employee(){ ID=2,Name="hp",City="pune"},
    new Employee(){ ID=3,Name="sp",City="pune"},
    new Employee(){ ID=4,Name="ssp",City="pune"}



};

company tcs=new company(employees) { Name="tata "};
tcs.Details();

string name = tcs[3];

Console.WriteLine(name);
tcs[4] = "hanamant";
Console.WriteLine(tcs[4]);
