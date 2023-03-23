//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int sum(int num)
{
    int res = 0;
    while ( num > 0) 
     {
    res += num % 10;
    num = num / 10;
}
return res;
}

int P = sum(int.Parse(Console.ReadLine()!));
Console.WriteLine(P);
