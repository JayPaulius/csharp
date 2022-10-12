// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Count(int num)
{
    int count = 0;
    if (num == 0) count = 1;
    
    while(num >= 1)
    {
        num /= 10;
        count++;
    }

    return count;
}

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());

Console.WriteLine(Count(num));