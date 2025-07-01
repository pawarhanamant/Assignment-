using System.Linq;

List<student> classs = new List<student> {

new student(){name="pawar",rollnu=12,age=17,city="pune" },
new student(){name="hppawar",rollnu=12,age=25,city="pune" },


new student(){name="raut",rollnu=13,age=18,city="solapur" },
new student(){name="shinde",rollnu=14,age=14,city="pandharpur" },
new student(){name="patil",rollnu=15,age=24,city="mum" }

};

Console.WriteLine("all class student");

foreach (student c in classs) {

   Console.WriteLine($" name :{c.name} and roll: {c.rollnu}  age:  {c.age} city:   {c.city}");
}
//
//IEnumerable<student>
    var pune  = classs.Where(s => s.city.Equals("pune"));
 Console.WriteLine("only pune student*****");
foreach (student c in pune)
{

    Console.WriteLine($" name :{c.name} and roll: {c.rollnu}  age:  {c.age} city:   {c.city}");
}

 var puneage = classs.Where(s => s.city.Equals("pune")&& s.age>20);
Console.WriteLine("****only pune  age < 20student*****");
foreach (student c in puneage)
{

    Console.WriteLine($" name :{c.name} and roll: {c.rollnu}  age:  {c.age} city:   {c.city}");
}

List<object> datataype = new List<object>() { 10,"pawar",20,'$',90,"raut"};

//var datatype = datataype.Where(o => o.GetType().Name == "Int32");
var datatype = datataype.OfType<int>();
foreach (object o in datatype) {
    Console.WriteLine(o);
}
Console.Read();


