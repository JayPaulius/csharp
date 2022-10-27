// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция элемента)

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

void ElementSearch(int[,] array)
{
    Console.WriteLine($"Строка:");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine($"Столбец:");
    int n = int.Parse(Console.ReadLine());
    if (m < array.GetLength(0) && n < array.GetLength(1))
        Console.WriteLine(array[m, n]);
    else Console.WriteLine("такого числа в массиве нет");
}

int[,] array = GetArray(5, 5, 1, 10);

PrintArray(array);
ElementSearch(array);