Console.WriteLine("Введите 5 значное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int num2 = (number / 1000) - (number * 10);
int num4 = (number % 100) / 10;

Console.WriteLine(num2);
Console.WriteLine(num4);