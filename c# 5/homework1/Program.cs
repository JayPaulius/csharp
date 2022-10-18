// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int CountOfNumbers(int[] array)
{
    int n = 0;
    foreach (var item in array)
    {
        if (item % 2 == 0)
            n++;
    }
    return n;
}

int[] array = GetArray(10, 100, 999);

PrintArray(array);

int count = CountOfNumbers(array);

Console.WriteLine(count);