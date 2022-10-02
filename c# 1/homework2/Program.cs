Console.WriteLine("Введите a:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите c:");
int c = int.Parse(Console.ReadLine());

int max = a;

if (b > a && b >c) max = b;
else if (c > a && c >b) max = c;

Console.WriteLine($"max = {max}");
