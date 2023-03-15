void t (int num)
{
    Console.WriteLine(num);
    if (num < 100)
    {
        Console.WriteLine("Tретьей цифры нет");
    }
    else
    {
        while (num > 999)
        {
            num = num / 10;
        }
        num = num % 10;
        Console.WriteLine(num);
    }
}
int r = new Random().Next(10,10000);
t(r);
