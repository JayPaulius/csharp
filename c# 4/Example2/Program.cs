
for (int i = 2; i < 10; i++)
{
    for (int j = 2; j < 10; j++)
    {
        Console.Write("{0, -15}", $"{j} * {i} = {j*i}");
    }
    Console.WriteLine();
}
