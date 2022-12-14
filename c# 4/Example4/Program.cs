int[] array = { 1, 6, 2, 4, -1 };

int length = array.Length;

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int min = i;

        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] > array[min])
                min = j;
        }

        int temp = array[i];
        array[i] = array[min];
        array[min] = temp;
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

PrintArray(array);

SelectionSort(array);

PrintArray(array);