// Задача 23

// Напишите программу, которая принимает 
// на вход число (N) 
// и выдаёт таблицу кубов 
// чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

TableCube (number);

// if (number > 0)
// {
//     TableCube (number);
// }
// else
// {
//     Console.WriteLine ("Введены некорректные данные");
// }

void TableCube (int num)
{
    int i = 1;
    
    while (i<=num)
    {
        Console.WriteLine($"{i, 4} -> {i*i*i, 4}");
        i++;
    }
}