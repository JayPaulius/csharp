// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] array = GetArray(5, 4, 1, 9);

PrintArray(array);
Console.WriteLine($"Строка с наимешьей суммой элементов: {RowMinSum(array)+1}");

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
    Console.WriteLine();
}

int RowMinSum(int[,] arrray)
{
    int row = 0;
    int sum = 0;
    int min = 0;
    Console.Write("Суммы элементов каждой строки: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        Console.Write($"{sum} ");
        if (i == 0) min = sum;
        if (sum < min)
        {
            min = sum;
            row = i;
        }
    }
    Console.WriteLine();
    return row;
}