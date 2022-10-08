int Max(int arg1, int arg2)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    return result;
}

int a1 = 15;
int a2 = 12;
int a3 = 11;
int a4 = 14;

// int max1 = Max(a1, a2);
// int max2 = Max(a3, a4);
// int max = Max(max1, max2);

int max = Max(Max(a1, a2), Max(a3, a4));

Console.WriteLine(max);
