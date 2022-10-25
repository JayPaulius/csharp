// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void Count()
{
    Console.WriteLine("Введите количество чисел:");
    int m = int.Parse(Console.ReadLine());
    int count = 0;

    for (int i = 1; i <= m; i++)
    {
        Console.WriteLine($"Введите {i}-е число:");
        int num = int.Parse(Console.ReadLine());
        if (num > 0) count++;
    }

    Console.WriteLine($"Количество чисел больше нуля: {count}");
}

Count();