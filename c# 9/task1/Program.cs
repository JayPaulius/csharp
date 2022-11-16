// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());

OutputNumbers(1, n);

void OutputNumbers(int a, int n)
{
    Console.Write($"{a} ");
    if (a < n) OutputNumbers(a + 1, n);
}