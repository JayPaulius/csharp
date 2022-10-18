// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива. 
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}

int[] array = GetArray(12, -9, 9);
int sumPos = 0;
int sumNeg = 0;

foreach (int element in array)
{
    if (element > 0)
        sumPos += element;
    else
        sumNeg += element;
}

Console.WriteLine();
Console.WriteLine($"сумма положительных чисел равна {sumPos}");
Console.WriteLine($"сумма отрицательных чисел равна {sumNeg}");

/*
int[] array = new int[12];

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

void Sum(int[] array)
{
    int sumPos = 0;
    int sumNeg = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            sumPos += array[i];
        else
            sumNeg += array[i];
    }
    Console.WriteLine($"сумма положительных чисел равна {sumPos}");
    Console.WriteLine($"сумма отрицательных чисел равна {sumNeg}");
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

FillArray(array);
PrintArray(array);
Sum(array);
*/