// // Задача 45: Напишите программу, которая 
//будет создавать копию заданного массива с помощью поэлементного копирования.


void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 11); // [1, 10]
}



void NewArray (int[] array)
{
   
    foreach (int i in array)
        Console.WriteLine(i);
        
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);

Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
NewArray(array);
Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");