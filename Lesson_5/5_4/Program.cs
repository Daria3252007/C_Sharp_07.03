// 4. Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

void PrintArr(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]}");
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
int[] productArr(int[] arr)
{
    int len = arr.Length;
    int[] res = new int[len / 2 + len % 2];

    for (int i = 0; i < len / 2; i++)
    {
        res[i] = arr[i] * arr[len - 1 - 1];
    }
    if (len % 2 == 1)
        res[res.Length - 1] = arr[len / 2];
    return res;
}
int[] array = RandArr();
PrintArr(array);
int[] endArr = productArr(array);
PrintArr(endArr);

