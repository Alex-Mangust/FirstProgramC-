int a = 1, b = 2, c = 6, d = 8, e = 4;
int max = a;
int number = 0;
while(number < 5)
{
    if(max < b)
    {
        max = b;
    }
    else if(max < c)
    {
        max = c;
    }
    else if(max < d)
    {
        max = d;
    }
    else if(max < e)
    {
        max = e;
    }
    number++;
}
Console.WriteLine("max = " + max);