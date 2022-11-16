// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Введите число:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());

if (m < n)
Console.WriteLine(OutputNumbers(m, n));
else
Console.WriteLine(OutputNumbers2(m, n));

string OutputNumbers(int m, int n)
{
    if (m <= n) return $"{m} " + OutputNumbers(m + 1, n);
    else return String.Empty;
}

string OutputNumbers2(int m, int n)
{
    if (m >= n) return $"{m} " + OutputNumbers2(m - 1, n);
    else return String.Empty;
}
