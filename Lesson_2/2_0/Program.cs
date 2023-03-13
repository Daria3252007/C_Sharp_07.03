int TekeNum(int num)
{
    Console.WriteLine(num);
    return num % 10;
}

// 123 % 10 -> 3
// 123 // 10 -> 12

int th_num = new Random().Next(100, 1000);
int result = TekeNum(th_num);
Console.WriteLine(result);
