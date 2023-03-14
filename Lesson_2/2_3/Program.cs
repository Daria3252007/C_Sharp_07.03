void Del(int a)
{
    Console.WriteLine(a);
    if (a%7==0 & a%23==0) 
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}
    int random = new Random().Next(1, 1000);
    Del(random);
    