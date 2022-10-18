// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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

void SearchElement(int[] array, int n)
{
    string message = "нет";
    foreach (int element in array)
    {
        if (element == n)
        {
            message = "да";
            break;
        }
    }
    Console.WriteLine(message);
}

int[] array = GetArray(10, -10, 10);

Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());

PrintArray(array);
SearchElement(array, n);