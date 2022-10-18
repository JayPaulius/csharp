Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());

while (a > 1000)
{
    a = a / 10;
}

if (a >= 100)
    Console.WriteLine(a % 10);
else
    Console.WriteLine("третьей цифры нет");
