int num = new Random().Next(100, 1000);

int a = num / 100 * 10;
int b = a + num % 10;

Console.WriteLine(num);
Console.WriteLine(b);