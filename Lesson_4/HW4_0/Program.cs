//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int n(int a, int b)
{
    int x = 1;
    for (int i = 0; i <= b; i++)
    {
        x *= a;
    }
    return x;
}
Console.WriteLine("A:");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("B:");
int b = int.Parse(Console.ReadLine()!);
int r = int.Parse(Console.ReadLine()!);
n(r);

