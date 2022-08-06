int max = 0;
int min = 0;
Console.Write("Введите значение a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b = ");
int b = Convert.ToInt32(Console.ReadLine());
if(a>b)
{
    max = a;
    min = b;
    Console.Write("max = ");
    Console.WriteLine(a);
    Console.Write("min = ");
    Console.WriteLine(b);
}
else
{
    max = b;
    min = a;
    Console.Write("max = ");
    Console.WriteLine(b);
    Console.Write("min = ");
    Console.WriteLine(a);
}


