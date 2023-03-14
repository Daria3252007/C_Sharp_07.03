int Nm(int num)
{
    num = num % 100;
    num = num / 10;
    return num;
}
int a = Nm(new Random().Next(100,1000));
Console.WriteLine(a);