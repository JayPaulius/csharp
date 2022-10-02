Console.WriteLine("Введите трехзначное число");
int n = int.Parse(Console.ReadLine());
if (n < 0) n = -n;
while (n > 999 || n < 100)
{
    Console.WriteLine("Введите трехзначное число");
    n = int.Parse(Console.ReadLine());
    if (n < 0) n = -n;
}

if (n < 0) n = -n;

int a = n % 10;

Console.WriteLine("Последняя цифра числа: " + a);
