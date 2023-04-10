// SЗадайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.

Console.Write("Enter number N: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Enter number M: ");
int num2 = int.Parse(Console.ReadLine()!);


void Sum(int N, int M)
{
    if (M >= N) return ;
    int n = 0;
    n = M + (M + 1);
    M++;
    Console.Write($"{n} ");
}
Sum(num, num2);
