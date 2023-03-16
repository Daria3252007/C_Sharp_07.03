//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube(int num)
{
    int c = 1;
    while (c <= num)
    {
        Console.WriteLine(Math.Pow(c,3));
        c++;
    }
}
Console.WriteLine("Число");
Cube(int.Parse(Console.ReadLine()!));