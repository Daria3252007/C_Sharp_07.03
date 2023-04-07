// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void a(int[,] arr)
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

int[,] A()
{
    Console.Write("Enter the number of rows: ");
    int row = int.Parse(Console.ReadLine()!);
    int column = row;

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
void b(int[,] arr2)
{
    int row_size = arr2.GetLength(0);
    int column_size = arr2.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr2[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] B()
{
    Console.Write("Enter the number of rows: ");
    int row = int.Parse(Console.ReadLine()!);
    int column = row;

    Console.Write("Enter the min number of massive ");
    int start = int.Parse(Console.ReadLine()!);
    Console.Write("Enter the max number of massive ");
    int stop = int.Parse(Console.ReadLine()!);

    int[,] arr2 = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr2[i, j] = new Random().Next(start, stop + 1);

    return arr2;
}
string matrix(int[,] arr, int[,] arr2)
{
    int res = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($" {arr[i, j]} ");
    for (int i = 0; i < arr2.GetLength(0); i++)
        for (int j = 0; j < arr2.GetLength(1); j++)
            Console.Write($" {arr2[i, j]} ");
    {
        res = arr[i, j] *= arr2[i, j];
    }
    return res;


}
int[,] mass = A();
a(mass);
int[,] mass2 = B();
b(mass2);
int[,] M = matrix();
matrix(M);

