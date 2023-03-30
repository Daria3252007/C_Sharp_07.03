// 2. Напишите программу, которая будет преобразовывать десятичное число в двоичное.

string binary(int num)
{
    string res = "";
    while(num>0)
    {
        res = num%2+res;
        num/=2;
    }
    return res;
}
Console.Write("enter a number");
int x = int.Parse(Console.ReadLine()!);
string anwers = binary(x);
Console.WriteLine(anwers);
