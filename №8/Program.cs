﻿Console.Write("Введите любое целое число, больше единицы - ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i<N)
{
    if (i % 2 == 0) 
    {
        Console.Write(i);
        Console.Write(", ");
        i = i + 1;

    }
    else 
    {
        i = i + 1;
    }
}

