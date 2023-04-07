// 3. Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз
// встречается элемент входных данных. Значения элементов массива 0..9

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums()
{
    Console.Write("Enter the number of rows: ");
    int row = int.Parse(Console.ReadLine()!);
    Console.Write("Enter the number of columns: ");
    int column = int.Parse(Console.ReadLine()!);

    Console.Write("Enter the min number of massive ");
    int start = int.Parse(Console.ReadLine()!);
    Console.Write("Enter the max number of massive ");
    int stop = int.Parse(Console.ReadLine()!);

    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(start, stop + 1);

    return arr;
}

int[] Odnom(int[,] arr, int stop)
{
    int[] a = new int[stop + 1];
    foreach (int i in arr)
    {
        a[i]++;
    }
    return a;
}
void Printt(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Число {i} встречается - {arr[i]} ");
    }
}

int[,] mass = MassNums();
int stop = int.Parse(Console.ReadLine()!);
Print(mass);
Odnom(mass,stop);
Printt(Odnom(mass,stop));




