// Задайте двумерный массив из целых чисел. Напишите программу,
//которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

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

void Removal(int[,] arr)
{
    int min = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            if (min > arr[i, j])
            {
                min = arr[i, j];
            }
}
int[,] mass = MassNums();
Print(mass);
Removal(mass);





