// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите любое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());



if (number > 0)
{
    int sumNumber = SumDigitsNumbers(number);
    Console.WriteLine($"Сумма цифр в числе {number} равна -> {sumNumber}");
}
else
{
Console.WriteLine("Неверные данные.");
}
int SumDigitsNumbers(int num)
{
    int sum = 0;

    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}