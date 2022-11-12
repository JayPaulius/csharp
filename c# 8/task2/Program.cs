// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.WriteLine("Количество строк");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Количество столбцов");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 1, 9);

if(rows == columns)
{
PrintArray(array);
array = RowsColumnsSwap(array);
PrintArray(array);
}
else Console.WriteLine("Количество строк не равно количеству столбцов");

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

int[,] RowsColumnsSwap(int[,] array)
{
    int[,] newArray = new int[array.GetLength(0),array.GetLength(1)];

    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(0); j++)
        {
            newArray[i,j] = array[j,i];
        }
    }
    
    return newArray;
}