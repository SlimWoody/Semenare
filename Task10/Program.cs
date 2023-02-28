// 10. Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трех значное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int unambiguous = Unambiguous(number);
Console.WriteLine($"Число: {unambiguous}");
int Unambiguous (int num)
{
    int num1 = num / 100;
    int num2 = num / 10;
    int result = num2 - (num1 * 10);
    return result;
}