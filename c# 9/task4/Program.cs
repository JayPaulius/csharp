// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите a:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b:");
int b = int.Parse(Console.ReadLine());

Console.WriteLine(Exponentiation(a, b));

int Exponentiation(int a, int b)
{
    if (b == 0) return 1;
    return a * Exponentiation(a, b - 1);
}
