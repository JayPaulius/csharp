// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// void Fibonacci(int n)
// {
//     int a = 0;
//     int b = 1;
//     int c = 0;
//     Console.Write($"{a} ");
//     for (int i = 0; i < n-1; i++)
//     {
//         c = a + b;
//         Console.Write($"{c} ");
//         b = a;
//         a = c;
//     }
// }

int[] Fibonacci(int size)
{
    int[] array = new int[size];

    array[0] = 0;
    array[1] = 1;

    for (int i = 2; i < size; i++)
    {
        array[i] = array[i-1] + array[i-2];
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

Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());
int[] array = Fibonacci(n);

PrintArray(array);