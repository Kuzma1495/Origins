//Вид 1
void Method1()
{
    Console.WriteLine("Kuzma");
}
Method1();



//Вид 2
void Method2(string msg, int count)
{
    int i = 1;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method2("Kuzma", 4);



//Вид 3

int Method3()
{
    return DateTime.Now.Year;
}
int Year = Method3();

Console.WriteLine(Year);


//Вид 4

//string Method4(int count, string c)
//{
    //int i = 0;
    //string result = String.Empty;

    //while(i < count)
   // {
        //result = result + c;
        //i++;
   // }
    //return result;
//}
//string res = Method4(10, "q");
//Console.WriteLine(res);


string Method4(int count, string c)
{
    string result = String.Empty;

    for(int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}
string res = Method4(10, "q");
Console.WriteLine(res);



//Цикл в цикле

for(int i = 2; i <= 10; i++)
{
    for(int j = 2; j <= 10; i++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}