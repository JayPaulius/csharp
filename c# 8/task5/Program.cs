// Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника

Console.WriteLine("Количество строк треугольника паскаля:");
int n = int.Parse(Console.ReadLine());
int c = 1;
for (int i = n; i > 1; i--)
{
    c = c + 2;
}
int[,] array = new int[n, c];

array = PascalTriangle(array);
PrintArray(array);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0, 3}", $"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] PascalTriangle(int[,] array)
{
    // num - количество элементов в строке, которые нужно заполнить
    // в каждой строке нужно заполнить на два элемента больше чем в предыдущей
    int num = 2;
    array[0, array.GetLength(1) / 2] = 1;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = (array.GetLength(1) - num) / 2; j <= (array.GetLength(1) + num) / 2; j++)
        {
            if (j == (array.GetLength(1) - num) / 2 || j == (array.GetLength(1) + num) / 2)
            {
                array[i, j] = 1;
            }
            else if (num > 3 && j < (array.GetLength(1)) - 1)
            {
                array[i, j] = array[i - 1, j - 1] + array[i - 1, j + 1];
            }
            j++;
        }
        num += 2;
    }
    return array;
}