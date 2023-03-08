// See https://aka.ms/new-console-template for more information

Console.WriteLine("Write if the number is even: ");
int a = int.Parse(Console.ReadLine()!);
if (a % 2 == 0)
{
Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
