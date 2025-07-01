var tranners = Trainer.GetAll();
Console.WriteLine($"");

foreach (var trainer in tranners) {
    Console.WriteLine($"trainer : id : {trainer.Id} name : {trainer.Name} experience : {trainer.Experience}");
}

var student = Student.GetAll();

Console.WriteLine("");


foreach (var item in student)
{
    Console.WriteLine($" name : {item.Name} city :{item.City} treanerid :{item.TrainerId} rollnumber :{item.RollNumber} "); 
}

var result = student.Join(tranners, s => s.TrainerId, t => t.Id, (s, t) => new { sName = s.Name, Tname = t.Name });

foreach (var item in result)
{
    Console.WriteLine($" student name :{item.sName} trainer name:{item.Tname}");
}

Console.Read();