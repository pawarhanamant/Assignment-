

student pl = delegate () {


    Console.WriteLine("this is anonymouse method ");

};
pl();

add pl1 = delegate (int a,int b) {

  return a + b;

};
 int result=pl1(10,10);
Console.WriteLine(result);






Console.Read();
