//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

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
    Console.Write("n ");
    int n = int.Parse(Console.ReadLine()!);


    int[,] arr = new int[row, column];

    for (int i = 1; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(start, stop + 1);
    if (column < n &&  row< n)
        Console.Write(" No element");
    return arr;
}
int[,] mass = MassNums();


