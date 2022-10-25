// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*

k1 * x + b1 = k2 * x + b2

k1x + b1 = k2x + b2 
k1x - k2x + b1 = b2
k1x - k2x = b2 - b1
x = (b2 - b1) / (k1 - k2)

5x + 2 = 9x + 4 
5x - 9x + 2 = 4
-4x + 2 = 4
-4x = 2
x = 2 / -4
x = -0,5

*/

int GetNumber()
{
    int n = int.Parse(Console.ReadLine());
    return n;
}

void PointOfIntersection(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    Console.WriteLine($"({x}; {k1*x + b1})");
}

Console.WriteLine("b1=");
double b1 = GetNumber();
Console.WriteLine("k1=");
double k1 = GetNumber();
Console.WriteLine("b2=");
double b2 = GetNumber();
Console.WriteLine("k2=");
double k2 = GetNumber();

PointOfIntersection(b1, k1, b2, k2);