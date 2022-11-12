// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных

Console.WriteLine("Количество строк");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Количество столбцов");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 9);

PrintArray(array);
NumbersFrequency(array);

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

void NumbersFrequency(int[,] array)
{
    for (int i = 0; i < 10; i++)
    {
        int count = 0;
        foreach (var item in array)
        {
            if (item == i)
                count++;
        }
        if (count != 0)
            Console.WriteLine($"{i} встречается {count} раз(а)");
    }
}
 