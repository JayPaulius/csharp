// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumOfNumbers(int[] array)
{
    int n = 0;
    for (int i = 1; i < array.Length; i+= 2)
    {
        n = n + array[i];
    }
    return n;
}

int[] array = GetArray(10, 1, 10);

PrintArray(array);

int sum = SumOfNumbers(array);

Console.WriteLine(sum);