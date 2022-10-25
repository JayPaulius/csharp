// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int[] CopyArray(int[] array)
{
    int[] array2 = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        array2[i] = array[i];
    }

    return array2;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] array = GetArray(10, 1, 10);
int[] array2 = CopyArray(array);

PrintArray(array);
PrintArray(array2);