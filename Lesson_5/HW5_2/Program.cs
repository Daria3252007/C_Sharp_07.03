// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void PrintArr(double[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]}");
    Console.WriteLine();
}
double[] RandArr()
{
    Console.Write("Enter array length: ");
    int len = int.Parse(Console.ReadLine()!);
    double[] arr = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
        arr[i] = rnd.Next(-100, 100) + rnd.NextDouble();
    for (int i = 0; i < len; i++)
        Console.WriteLine($"{arr[i]}");
    return arr;
}
double MinMax(double[] arr)
{
    double min =arr[0];
    double max =arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]<min)
        min=arr[i];
        if (arr[i]>max)
        max=arr[i];
    }
    double diff= max- min;
    return diff;
}


double[] mass = RandArr();
double res=MinMax(mass);
Console.Write(res);

