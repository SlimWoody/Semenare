﻿// Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.

Console.WriteLine("Введите любое целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;
if (number > 1)
{
    while (count <= number)
    {
        Console.Write(count + " ");
        count = count + 2;
    }
}
else
{
    Console.WriteLine("!!!Введите число больше 1!!!");
}