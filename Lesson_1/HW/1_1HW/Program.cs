// See https://aka.ms/new-console-template for more information

Console.WriteLine("Write a number max: ");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
int max=0;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine(max);