// See https://aka.ms/new-console-template for more information


Console.Clear();
Console.Write("Четверть");
int a = Convert.ToInt32(Console.ReadLine());


if (a == 1)
    Console.WriteLine("x > 0 && y > 0");
else if (a == 2)
    Console.WriteLine("x < 0 && y > 0");
else if (a == 3)
    Console.WriteLine("x < 0 && y < 0");
else if (a == 4)
    Console.WriteLine("x > 0 && y < 0");
else
    Console.WriteLine("Введите число от 1 до 4");
