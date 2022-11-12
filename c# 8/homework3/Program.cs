// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Введите количество строк и столбцов двух матриц. Количество столбцов матрицы А должно быть равно количеству строк матрицы В");

Console.WriteLine("Количество строк матрицы A");
int rows1 = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество столбцов матрицы A");
int columns1 = int.Parse(Console.ReadLine());

Console.WriteLine("Количество строк матрицы B");
int rows2 = int.Parse(Console.ReadLine());
if (columns1 != rows2)
{
    Console.WriteLine("Количество столбцов матрицы А должно быть равно количеству строк матрицы В");
    return;
}
Console.WriteLine("Количество столбцов матрицы B");
int columns2 = int.Parse(Console.ReadLine());

int[,] array1 = GetArray(rows1, columns1, 1, 9);
int[,] array2 = GetArray(rows2, columns2, 1, 9);

Console.WriteLine("Матрица A:");
PrintArray(array1);
Console.WriteLine("Матрица B:");
PrintArray(array2);
Console.WriteLine("Произведение матриц:");
PrintArray(MatrixProduct(array1, array2));

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
            Console.Write("{0, 5}", $"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MatrixProduct(int[,] arr1, int[,] arr2)
{
    int[,] arr3 = new int[arr1.GetLength(0), arr2.GetLength(1)];
    int sum = 0;
    for (int l = 0; l < arr3.GetLength(0); l++) // l - строки arr1 и arr3
    {
        for (int i = 0; i < arr2.GetLength(1); i++) // i - столбцы arr2  и arr3
        {
            sum = 0;
            if (arr1.GetLength(1) > arr2.GetLength(1))
                for (int j = 0; j < arr2.GetLength(0); j++) // j - столбцы arr1 и строки arr2
                {
                    sum += arr1[l, j] * arr2[j, i];
                    if (j == arr1.GetLength(1) - 1)
                    {
                        arr3[l, i] = sum;
                    }
                }
            else if (arr1.GetLength(1) == arr2.GetLength(1))
                for (int j = 0; j < arr2.GetLength(0); j++)
                {
                    sum += arr1[l, j] * arr2[j, i];
                    if (j == arr3.GetLength(1) - 1)
                    {
                        arr3[l, i] = sum;
                    }
                }
            else
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    sum += arr1[l, j] * arr2[j, i];
                    if (j == arr1.GetLength(1) - 1)
                    {
                        arr3[l, i] = sum;
                    }
                }
        }
    }
    return arr3;
}