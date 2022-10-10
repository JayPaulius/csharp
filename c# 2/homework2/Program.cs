Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());
int b = 0;

while (a > 1000)
{
    a = a / 10;
}

a = a % 10;

Console.WriteLine(a);