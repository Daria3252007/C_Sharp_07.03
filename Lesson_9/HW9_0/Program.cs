// Задайте значения M и N. Напишите программу, которая выведет все чётные
// натуральные числа в промежутке от M до N с помощью рекурсии.

Console.Write("Enter number N: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Enter number M: ");
int num2 = int.Parse(Console.ReadLine()!);


void Even(int N, int M)
{
    if (M% 2 ==0)
    if (N <= M) return;
    Even(N, M += 2);
    Console.WriteLine($"{M} ");
}
Even(num,num2);
