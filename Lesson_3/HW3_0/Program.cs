//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Five(int num)
{
    Console.WriteLine(num);
    int n1 = num / 10000;
    int n4 = num % 10;
    int n2 = num / 1000 % 10;
    int n3 = num / 10 % 10;
    if (n1 == n4 & n2 == n3)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("no");
    }
}
int random = new Random().Next(10000, 100000);
Five(random);
//Five(int.Parse(Console.ReadLine()!));