﻿// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите номер четверти: ");
int quarterNumber = Convert.ToInt32(Console.ReadLine());
string rangeCoordinate = RangeCoordinate (quarterNumber);

Console.WriteLine (rangeCoordinate);

string RangeCoordinate (int quarter)
{
    if (quarter==1) return "x > 0, y > 0";
    if(quarter==2) return "x < 0, y > 0";
    if(quarter==3) return "x < 0, y < 0";
    if(quarter==4) return "x > 0, y < 0";
    return "неверное значение";
}