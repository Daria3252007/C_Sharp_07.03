

void PrintArr(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]}   ");
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
void Rev(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size / 2; i++)
        (arr[i], arr[size - i - 1]) = (arr[size - i - 1],arr[i]);
}

int[] mass = RandArr();
PrintArr(mass);
Rev(mass);
PrintArr(mass);
