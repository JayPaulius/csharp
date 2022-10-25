// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

void TriangleCheck(int a, int b, int c)
{
    if (a <= b + c && b <= a + c && c <= a + b)
    {
        Console.WriteLine("да");
    }
    else Console.WriteLine("нет");
}

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

TriangleCheck(a, b, c);