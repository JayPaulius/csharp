Console.WriteLine("Введите n:");
int n = int.Parse(Console.ReadLine());

if (n >= 0)
{
    int a = -n;
    while (a <= n)
    {
        if (a == n)
            Console.Write(a);
        else Console.Write(a + ",");
        a++;
    }
}
else
{
    int a = n;
    while (a <= -n)
    {
        if (a == n)
            Console.Write(a);
        else Console.Write(a + ",");
        a++;
    }
}
