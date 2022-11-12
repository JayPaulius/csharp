// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

int[,] array = GetArray(4, 4, 0, 9);

PrintArray(array);
array = DeleteRowColumn(array);
PrintArray(array);

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

int[,] DeleteRowColumn(int[,] array)
{
    int min = array[0, 0];
    int k = 0;
    int l = 0;
    int m = 0;
    int n = 0;
    foreach (var item in array)
    {
        if (item < min) min = item;
    }
    bool exit = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == min)
            {
                k = i;
                l = j;
                exit = true;
                break;
            }
        }
        if (exit) break;
    }
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (m == newArray.GetLength(0)) break;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == k) i++;
            if (j == l) j++;
            newArray[m, n] = array[i, j];
            n++;
            if (n == newArray.GetLength(1)) break;
        }
        n = 0;
        m++;
    }

    return newArray;
}