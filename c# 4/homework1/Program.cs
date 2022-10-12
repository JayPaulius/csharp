// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Exponentiation(int a, int b)
{
    double exponentiation = 1;
    if (b >= 0)
    {
        for (int i = b; i > 0; i--)
        {
            exponentiation *= a;
        }
    }
    else
    {
        b *= -1;
        for (int i = b; i > 0; i--)
        {
            exponentiation *= a;
        }
        exponentiation = 1 / exponentiation;
    }
    return exponentiation;
}

Console.WriteLine("Введите a:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b:");
int b = int.Parse(Console.ReadLine());

Console.WriteLine(Exponentiation(a, b));