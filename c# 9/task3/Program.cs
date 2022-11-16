// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(SumOfNumbers(n));


int SumOfNumbers(int n)
{
    if (n > 0) return n % 10 + SumOfNumbers(n/ 10);
    else return 0;
}

// int SumOfNumbers(int n)
// {
//     int sum = 0;
//     while (n > 0)
//     {
//         sum += n % 10;
//         n /= 10;
//     }
//     return sum;
// }