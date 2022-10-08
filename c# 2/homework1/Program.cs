Console.WriteLine("Введите трехзначное число:");
int a = int.Parse(Console.ReadLine());
while (a < 100 || a > 999)
{
    Console.WriteLine("Введите трехзначное число:");
    a = int.Parse(Console.ReadLine());
}

int b = a % 100 / 10;

Console.WriteLine(b);