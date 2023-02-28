// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
int twoDigit = TwoDigit (number);
Console.WriteLine($"Из трехзначного числа {number} получаем двухначное {twoDigit}");

int TwoDigit (int num)
{
int firstNumber = num / 100;
int secondNumber = num % 10;
int sum = firstNumber * 10 + secondNumber;
return sum;
}
