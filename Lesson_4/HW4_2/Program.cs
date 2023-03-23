//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int m(int l, int a, int b)
{
    int[] arr = new int[l];
    for (int i = 1; i <= l; i++)
    {
        arr[i] = new Random().Next(a, b);
    }
    return arr;
}
Console.WriteLine("Длина:");
int l = int.Parse(Console.ReadLine()!);
Console.WriteLine("Начало:");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Конец:");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine(m);
