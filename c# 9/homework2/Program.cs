// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(SumOfNumbers(m, n));

int SumOfNumbers(int m, int n)
{
    if (m > n) return 0;
    else return m + SumOfNumbers(m + 1, n);
}