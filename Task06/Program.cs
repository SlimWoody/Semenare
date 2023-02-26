// Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).
Console.WriteLine("Введите любое целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA % 2 == 0)
{
    Console.WriteLine($"Число {numberA} является четным!");
}
else
{
    Console.WriteLine($"Число {numberA} НЕ является четным!");
}