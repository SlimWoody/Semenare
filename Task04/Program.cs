// Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите три числа");
Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int max = numberA;
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.WriteLine($"Максимальное число = {max}");