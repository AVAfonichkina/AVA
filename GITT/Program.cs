void DemoSlv(int a, int b, int pokaz, int razi)
{
    int c = 0;
    while (c < pokaz) 
    {   
        a = a*b;
        Console.WriteLine(a);
        c++;
    }
    c = 0;
    while (c < razi-1)
    {
        Console.WriteLine(a);
        c++;
    }
}

Console.Clear();
DemoSlv(1,2,5,3);