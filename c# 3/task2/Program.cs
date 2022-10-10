int num = 0;

while (num < 1 || num > 4)
{
    Console.WriteLine("Введите номер четверти плоскости от 1 до 4:");
    num = int.Parse(Console.ReadLine());
}

if (num == 1) Console.WriteLine("x; y");
else if (num == 2) Console.WriteLine("-x; y");
else if (num == 3) Console.WriteLine("-x; -y");
else Console.WriteLine("x; -y");
