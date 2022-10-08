Console.WriteLine("Введите число a:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b:");
int b = int.Parse(Console.ReadLine());
while (b == 0)
{
    Console.WriteLine("Введен ноль");
    b = int.Parse(Console.ReadLine());
}

int c = a % b;

if (c == 0)
Console.WriteLine("кратно");
else
Console.WriteLine($"не кратно, остаток {c}");
