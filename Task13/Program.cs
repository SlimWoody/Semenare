// Задача 13: Напишите программу,
//  которая
//  выводит третью цифру заданного 
//  числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int threeDigit = ThreeDigit(number);
Console.WriteLine(threeDigit);

int ThreeDigit(int num)
{
    if (num < 100)
    {
        Console.WriteLine("Нет третьего числа");
    }
    else
    {
        while (num > 999)
        {
            num = num / 10;
        }
        num = num % 10;
        
    }
    return num;
}



