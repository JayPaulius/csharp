// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigits(int num)
{
    int sum = 0;
    if (num < 0) num *= -1;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());

Console.WriteLine(SumDigits(num));