// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях

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
    Console.Write("Enter minimal range value: ");
    int min = int.Parse(Console.ReadLine()!);
    Console.Write("Enter maximum range value: ");
    int max = int.Parse(Console.ReadLine()!);

    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
        arr[i] = new Random().Next(min, max + 1);
    return arr;
}
int Position(int[] mas)
{
    int x = 0;
    for (int i = 0; i < mas.Length; i+=2)
    {
        x += 1;
    }
    return x;
}
int[] mass = RandArr();
Console.WriteLine(Position(mass));
