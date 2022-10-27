// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ColumnAverage(int[,] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    double average = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            average += array[i, j];
        }
        average = Math.Round(average / array.GetLength(0), 1);
        if (j == array.GetLength(1)-1) Console.Write($"{average}");
        else Console.Write($"{average}, ");
        average = 0;
    }
}

Console.WriteLine($"Количество строк");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество столбцов");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 1, 9);

PrintArray(array);
ColumnAverage(array);