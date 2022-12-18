int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>result) result = arg2;
    if(arg3>result) result = arg3;
    return result;
}


int a1 = 21;
int b1 = 23;
int c1 = 4;
int a2 = 6;
int b2 = 78;
int c2 = 43;
int a3 = 155;
int b3 = 24;
int c3 = 98;

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);