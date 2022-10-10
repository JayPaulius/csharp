Console.WriteLine("Введите координаты первой точки:");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки:");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());

double result = (Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));

Console.WriteLine($"Расстояние между двумя точками: {Math.Round(result, 2)}");