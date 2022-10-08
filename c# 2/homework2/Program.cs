Console.WriteLine("Введите трехзначное число:");
int a = int.Parse(Console.ReadLine());
int b = 0;

if (a < 100)
    Console.WriteLine("третьей цифры нет");
else
{
    b = a % 1000 / 100;
    Console.WriteLine(b);
}