// 2. Задайте двумерный массив. Напишите программу,которая заменяет строки на столбцы. В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.

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
void Reversal(int[,] arr)
{
    if (arr.GetLength(0) == arr.GetLength(1))
    {
        for (int i = 0; i < arr.GetLength(0); i++)
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                (arr[i, j], arr[j, i]) = (arr[j, i], arr[i, j]);
            }
        Console.WriteLine("Матрица изменена");
    }
    else Console.WriteLine("Данный массив не подходит ");
}
int[,] mass = MassNums();
Print(mass);
Reversal(mass);
Print(mass);






