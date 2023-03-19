int SunNum(int num)
{
    int all_sum = 0;

    for (int i = 0; i <= num; i++)
        all_sum += i;
    return all_sum;
}
int val = int.Parse(Console.ReadLine()!);
int result = SunNum(val);
Console.WriteLine(result);
