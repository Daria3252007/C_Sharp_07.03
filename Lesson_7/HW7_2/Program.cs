// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void Print(int[,] arr)
{
    int column_size = arr.GetLength(1);
    int row_size = arr.GetLength(0);

    for (int i = 0; i < column_size; i++)
    {
        for (int j = 0; j < row_size; j++)
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

    for (int j = 0; j < column; j++)
        for (int i = 0; i < row; i++)
            arr[i, j] = new Random().Next(start, stop + 1);

    return arr;
}
void Average(int[,] arr)
{

    int row = int.Parse(Console.ReadLine()!);
    int res = 0;
    for (int i = 1; i < arr.GetLength(0); i++)
        for (int j = 1; j < arr.GetLength(0); j++)
            res = arr[i, j] *= arr[i, j];
    res = res / row;
}
int[,] mass = MassNums();
Print(mass);
Average(mass);
Print(mass);





