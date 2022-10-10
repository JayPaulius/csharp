Console.WriteLine("Введите n:");
int n = int.Parse(Console.ReadLine());
int a = 0;
int b = n;

while (b > 0)
{
    a = b % 10 + a * 10;
    b = b / 10;
}

if (a == n)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");