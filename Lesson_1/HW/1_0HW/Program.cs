// See https://aka.ms/new-console-template for more information

Console.WriteLine("Write a number max and min: ");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
if (a > b)
{
    Console.WriteLine("max = a min = b");   
}
else if (b > a)
{
    Console.WriteLine("max = b min = a");
}


