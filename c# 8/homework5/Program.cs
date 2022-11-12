// Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] array = GetArray(4, 4);

PrintArray(array);

int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int count = rows * columns;
    int num = 1;
    for (int j = 0; j < columns; j++)
    {
        array[0, j] = num;
        num++;
    }
    for (int j = 1; j < columns; j++)
    {
        array[j, columns - 1] = num;
        num++;
    }
    for (int j = columns - 2; j >= 0; j--)
    {
        array[rows - 1, j] = num;
        num++;
    }
    for (int j = rows - 2; j > 0; j--)
    {
        array[j, 0] = num;
        num++;
    }
    for (int j = 1; j < columns - 1; j++)
    {
        array[1, j] = num;
        num++;
    }
    for (int j = columns - 2; j > 0; j--)
    {
        array[rows - 2, j] = num;
        num++;
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0, 5}", $"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}