#region revers order orderdesending then etc
//List<int> number = new List<int>() {5,1,3,7,8,2,4,6};
// Console.WriteLine("");
//foreach (int i in number) {

//    Console.Write($"{i}\t");
//}
//Console.WriteLine("******");

//number.Reverse();
//foreach (int i in number)
//{

//    Console.Write($"{i}\t");
//}


//IOrderedEnumerable<int > order=number.OrderBy(x => x);
//Console.WriteLine("****order by method ***");

//foreach (int i in order) {
//    Console.Write($"{i}\t");
//}
//Console.WriteLine("");


//var orderdesc= number.OrderByDescending(x => x);
//Console.WriteLine("****order by method ***");

//foreach (int i in orderdesc)
//{
//    Console.Write($"{i}\t");
//}
//Console.WriteLine("");



//List<student> classs = new List<student>() {

//   new student(){ name="pawar",age =23,mar=90,roll=12 },
//   new student(){ name="raut",age =18,mar=49,roll=13 },
//   new student(){ name="shinde ",age =89,mar=70,roll=14 },
//   new student(){ name="sale",age =34,mar=60,roll=15 },
//   new student(){ name="patil",age =15,mar=75,roll=16 },


//};

//foreach (student s in classs) 
//{
//    Console.WriteLine($" name:{s.name} age:{s.age} mar:{s.mar} roll:{s.roll}");
//}

//var thenbyy = classs.OrderByDescending(x => x.mar).ThenBy(x=>x.name);
//Console.WriteLine("****then by method ***");

//foreach (student i in thenbyy)
//{
//    Console.Write($"mar:{i.mar} name:{i.name}\t");
//}
//Console.WriteLine("");


//var thenby = classs.OrderBy(x => x.mar).ThenByDescending(x=>x.name);
//Console.WriteLine("**** ThenByDescending **");

//foreach (student i in thenby)
//{
//    Console.Write($"mar:{i.mar} name:{i.name}\t");
//}
//Console.WriteLine("");

#endregion evers order orderdesending then etc

#region first overload
//List<student> classs = new List<student>() {

//   new student(){ name="pawar",age =23,mar=90,roll=12 },
//   new student(){ name="raut",age =18,mar=49,roll=13 },
//   new student(){ name="shinde ",age =89,mar=70,roll=14 },
//   new student(){ name="sale",age =34,mar=60,roll=15 },
//   new student(){ name="patil",age =15,mar=75,roll=16 },


//};

//classs.Sort();
//foreach (var s in classs)
//{
//       Console.WriteLine($" name:{s.name} age:{s.age} mar:{s.mar} roll:{s.roll}");

//}

#endregion first overload

List<studentt> clas = new List<studentt>() {

   new studentt(){ name="pawar",age =23,mar=90,roll=12,gender="male"},
   new studentt(){ name="raut",age =18,mar=49,roll=11,gender = "female" },
   new studentt(){ name="shinde ",age =89,mar=70,roll=14 ,gender = "male"},
   new studentt(){ name="sale",age =34,mar=60,roll=15 , gender = "female"},
   new studentt(){ name="patil",age =15,mar=75,roll=10 , gender = "male"},


};

//clas.Sort(new MarksComparer());

//foreach (var s in clas)
//{
//    Console.WriteLine($"{s.name} - {s.mar}");
//}



Console.WriteLine("student age limited sort");

//clas.Sort(new MarksCompa());
//clas.Sort(0,3,new MarksCompa());
clas.Sort((x,y)=>x.roll.CompareTo(y.roll));
foreach (var s in clas)
{
    Console.WriteLine($" student name is:{s.name}:age is:{s.age}");
}



//var result = clas.GroupBy(s => s.gender);
var result = clas.ToLookup(s => s.gender);
Console.WriteLine("to  ToLookup method *********");
foreach (var group  in result)
{
    Console.WriteLine($" student name is:{group.Key}");

    foreach (var item in group)

    {
        Console.WriteLine($"{item.name}");

    }
}








Console.Read();
