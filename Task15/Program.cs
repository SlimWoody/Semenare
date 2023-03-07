// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введи цифру от 1 до 7: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

CheckingTheDayOfTheWeek(dayNumber);

void CheckingTheDayOfTheWeek(int day)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("да");
    }
    else if (day < 1 || day > 7)
    {
        Console.WriteLine("вне диапазона от 1-7");
    }
    else Console.WriteLine("нет");
}


