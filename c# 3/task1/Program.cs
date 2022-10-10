int x = 0;
int y = 0;

while (x == 0)
{
    Console.WriteLine("Введите x <> 0:");
    x = int.Parse(Console.ReadLine());
    if (x != 0)
    while (y == 0)
    {
        Console.WriteLine("Введите y <> 0:");
        y = int.Parse(Console.ReadLine());
    }
}

if (x > 0 && y > 0) Console.WriteLine("Точка находится в 1 четверти плоскости");
else if (x < 0 && y > 0) Console.WriteLine("Точка находится во 2 четверти плоскости");
else if (x < 0 && y < 0) Console.WriteLine("Точка находится в 3 четверти плоскости");
else Console.WriteLine("Точка находится в 4 четверти плоскости");
