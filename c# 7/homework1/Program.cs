// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GetArray(int rows, int columns, double minValue, double maxValue)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round((new Random().NextDouble() * (maxValue - minValue) + minValue), 1);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0, 5}", $"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine($"Количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество столбцов");
int n = int.Parse(Console.ReadLine());
double [,] array = GetArray(m, n, 1, 10);

PrintArray(array);