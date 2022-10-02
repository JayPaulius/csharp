Console.WriteLine("Введите a:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b:");
int b = int.Parse(Console.ReadLine());

int max = a;
int min = b;

if (b > a)
{
    max = b;
    min = a;
}

Console.WriteLine($"max = {max}");
Console.WriteLine($"min = {min}");
