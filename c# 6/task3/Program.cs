// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

void DecToBin(int n)
{
    string bin = string.Empty;

    while (n > 0)
    {
        bin = String.Concat(Convert.ToString(n % 2), bin);
        n /= 2;
    }

    Console.WriteLine(bin);
}

Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());

DecToBin(n);