//2. Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.


void Print(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]}");
    Console.WriteLine();
}
int[] EightMass(int size, int from, int to)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to + 1);
    return arr;
}
bool TryFols(int[] array, int desirednumber)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == desirednumber)
        {
            return true;
        }
    }
    return false;
}
int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int[] mass = EightMass(num, start, stop);
int[] array_1 = EightMass(num,start,stop);
Print(array_1);
int g = int.Parse(Console.ReadLine()!);
Console.WriteLine(TryFols(mass, g));
Console.WriteLine(TryFols(array_1, g));