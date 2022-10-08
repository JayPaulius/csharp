Console.WriteLine("Введите цифру дня недели от 1 до 7:");
int a = int.Parse(Console.ReadLine());
while (a < 1 || a > 7)
{
    Console.WriteLine("Введите цифру дня недели от 1 до 7:");
    a = int.Parse(Console.ReadLine());
}

if (a > 5) Console.WriteLine("выходной");
else Console.WriteLine("не выходной");