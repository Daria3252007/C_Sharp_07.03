//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void PrintArr(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]}");
    Console.WriteLine();
}
int[] RandArr()
{
    Console.Write("Enter array length: ");
    int len = int.Parse(Console.ReadLine()!);
    int min = 100;
    int max = 999;
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
        arr[i] = new Random().Next(min, max + 1);
    return arr;
}
int Even(int[] mas)
{
    int n = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] % 2 == 0)
        {
            n += 1;
        }
    }
    return n;
}
int[] mass = RandArr();
Console.WriteLine(Even(mass));
