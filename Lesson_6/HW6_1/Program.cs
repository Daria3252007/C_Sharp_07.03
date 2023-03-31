//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Enter b1: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter k1: ");
int k1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter b1: ");
int b2 = int.Parse(Console.ReadLine()!);
Console.Write("Enter k2: ");
int k2 = int.Parse(Console.ReadLine()!);
void Direct(int b1, int k1, int b2, int k2)
{
    int x = 1;
    int y = 1;
    y = k1 * x + b1;
    y = k2 * x + b2;
    {
        Console.WriteLine("Точкa пересечения");
        Console.WriteLine(y);
    }
}
Direct(b1, k1, b2, k2);

