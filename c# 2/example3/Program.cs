int[] array = { 12, 23, 31, 45, 56, 64, 79, 87, 98 };

int n = array.Length;
int find = 31;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
