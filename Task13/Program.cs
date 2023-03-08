// Задача 13: Напишите программу,
//  которая
//  выводит третью цифру заданного 
//  числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number > 99)
{
    int threeDigit = ThreeDigit(number);
    Console.WriteLine($"Третья цифра числа {number} -> {threeDigit}");
}
else
{
    Console.WriteLine("Третьей цыфры нет!");
}

int ThreeDigit(int num)
{

    while (num > 999)
    {
        num = num / 10;
    }
    num = num % 10;


    return num;
}



