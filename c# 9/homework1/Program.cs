// Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2,"

Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(OutputNumbers(n, 2));

string OutputNumbers(int n, int a)
{
    if (n % 2 != 0) n -= 1;
    if (n < a) return String.Empty;
    else return $"{n} " + OutputNumbers(n - 2, a);
}