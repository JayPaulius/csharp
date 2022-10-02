Console.WriteLine("Введите номер дня недели:");
int num = int.Parse(Console.ReadLine());

if (num == 1) Console.WriteLine("пн");
else if (num == 2) Console.WriteLine("вт");
else if (num == 3) Console.WriteLine("ср");
else if (num == 4) Console.WriteLine("чт");
else if (num == 5) Console.WriteLine("пт");
else if (num == 6) Console.WriteLine("сб");
else if (num == 7) Console.WriteLine("вс");
else Console.WriteLine("Введен неверный номер дня недели");
