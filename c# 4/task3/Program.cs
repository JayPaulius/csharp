// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int ProductOfNumbers(int num)
{
    int multiply = 1;

    for (int i = 1; i <= num; i++)
    {
        multiply *= i;
    }

    return multiply;
}

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());

Console.WriteLine(ProductOfNumbers(num));