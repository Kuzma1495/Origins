// Задача №17. 
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


Console.Clear();
Console.Write("Координату x: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Координату y: ");
double y = Convert.ToDouble(Console.ReadLine());

if (x > 0 && y > 0)
    Console.WriteLine("I");
else if (x < 0 && y > 0)
    Console.WriteLine("II");
else if (x < 0 && y < 0)
    Console.WriteLine("III");
else
    Console.WriteLine("IV");
