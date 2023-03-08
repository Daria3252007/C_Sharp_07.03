// See https://aka.ms/new-console-template for more information
Console.WriteLine("Write all even numbers from 1 to N");
int N = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= N; i++)
{
    if(i %2 ==0)
    {
        Console.WriteLine(i);
    }
}