//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

void Print(double[,] arr)
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

double[,] MassNums()
{
    Console.Write("Enter the number of rows: ");
    int row = int.Parse(Console.ReadLine()!);
    Console.Write("Enter the number of columns: ");
    int column = int.Parse(Console.ReadLine()!);
    Random rnd = new Random();
    double[,] arr = new double[row, column];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = rnd.Next(-100, 100) + rnd.NextDouble();
    return arr;
}
double[,] mass = MassNums();
Print(mass);





