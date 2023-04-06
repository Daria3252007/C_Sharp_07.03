// 4. Задайте двумерный массив. Введите элемент, и найдите первое его вхождение,
// выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.

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
string Find(int[,] matr, int a)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (a == matr[i, j])
                return $"{i + 1},{j + 1}";
        }
    }
    return "No";
}
Console.Write("Enter the number ");
int numb = int.Parse(Console.ReadLine()!);
int[,] mass = MassNums();
Print(mass);
Console.WriteLine(Find(mass, numb));



