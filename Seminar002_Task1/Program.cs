// Напишите программу, 
//которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

Console.Clear();

int n = new Random().Next(100, 1000);
int n1 = n / 100;
int n3 = n % 10;
Console.WriteLine(n);

Console.WriteLine(n1*10 + n3);