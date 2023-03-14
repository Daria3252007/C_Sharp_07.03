int a(int num)
{
    Console.WriteLine(num);
    int num1 = num / 100;
    int num2 = num % 10;
    int res = num1 * 10 + num2;
    return res;
}
int b = a(new Random().Next(100,1000));
Console.WriteLine(b);