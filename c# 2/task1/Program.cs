int num = new Random().Next(10, 100);
int a = num % 10;
int b = num / 10;
int max = a;

if (b > a) max = b;

Console.WriteLine(num);
Console.WriteLine(max);
