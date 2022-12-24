// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 2D пространстве.


Console.Clear();

Console.Write("Координату x первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координату y первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Координату x второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координату y второй точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write(Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)));
