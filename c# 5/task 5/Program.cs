// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве. 
// [1 2 3 4 5] -> 5 8 3 
// [6 7 3 6] -> 36 21

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

int[] ProductOfNumber(int[] array)
{
    int size = array.Length - 1;
    int[] array2;

    if (array.Length % 2 == 0)
        array2 = new int[array.Length / 2];
    else
        array2 = new int[array.Length / 2 + 1];

    for (int i = 0; i <= size; i++)
    {
        if (i == size)
        {
            array2[i] = array[i];
            break;
        }
        array2[i] = array[i] * array[size];
        size--;
    }
    return array2;
}

int[] array = GetArray(10, 1, 10);
int[] array2 = ProductOfNumber(array);

PrintArray(array);
PrintArray(array2);