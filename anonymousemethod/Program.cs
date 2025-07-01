printa sc = delegate {

    Console.WriteLine("hello ");
};

sc();

printB b = delegate {
    return 10;
};
int res=b();
Console.WriteLine(res);

printC c = delegate (int y, int x) {

    return y+x;
};
int result= c(10,30);
Console.WriteLine(result);

Console.Read();