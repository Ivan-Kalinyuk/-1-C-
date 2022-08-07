Console.Write("Введите значение a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение c = ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

    if(b>a) 
    {
        max = b;
        if (c>b)
        {
            max = c;
        }
        Console.Write("max = ");
        Console.WriteLine(max);
        
    }
    else
    {
        if (c>a)
        {
            max = c;
        }
        else 
        {
            max = a;
        }
        Console.Write("max = ");
        Console.WriteLine(max);
    }







