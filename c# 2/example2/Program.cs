int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = { 12, 23, 31, 45, 56, 64, 79, 87, 98 };

// int max1 = Max(a1, a2);
// int max2 = Max(a3, a4);
// int max = Max(max1, max2);

int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));

Console.WriteLine(max);
