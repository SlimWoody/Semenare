// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int number = Input("Введите число: ");

Console.Write($"N = {number} -> \"");

OutputNumber(number);


void OutputNumber(int num)
{
    if (num == 0) return;
    if (num > 1)
    {
        Console.Write($"{num}, ");
        OutputNumber(num - 1);
    }
    if (num == 1)
    {
        Console.Write($"{num}\"");
        OutputNumber(num - 1);
    }

}


int Input(string text)
{
    Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}